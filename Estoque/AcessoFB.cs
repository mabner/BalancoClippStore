using System;
using System.Configuration;
using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace Balanco
{
    public class AcessoFB
    {
        private static readonly AcessoFB instanciaFireBird = new AcessoFB();
        private AcessoFB() { }

        public static AcessoFB getInstancia()
        {
            return instanciaFireBird;
        }

        public FbConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
            return new FbConnection(conn);
        }

        public static DataTable fb_GetDados()
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "select tb_est_produto.cod_barra, TB_ESTOQUE.descricao, tb_est_produto.qtd_atual, TB_ESTOQUE.id_estoque from tb_estoque, tb_est_produto where tb_estoque.id_estoque = tb_est_produto.id_identificador";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataAdapter da = new FbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static Produto fb_ProcuraDados(long barra)
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "select tb_est_produto.cod_barra, tb_estoque.descricao, tb_est_produto.qtd_atual, tb_estoque.id_estoque from tb_estoque, tb_est_produto where tb_estoque.id_estoque = tb_est_produto.id_identificador and tb_est_produto.cod_barra = '" + barra + "'";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();
                    Produto prod = new Produto();
                    while (dr.Read())
                    {
                        prod.Barras = Convert.ToInt64(dr[0]);
                        prod.Descricao = dr[1].ToString();
                        prod.Quantidade = Convert.ToInt64(dr[2]);
                    }
                    return prod;
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static void fb_AlterarDados(Produto prod)
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "Update tb_est_produto set qtd_atual = '" + prod.Quantidade + "' Where cod_barra = '" + prod.Barras + "'";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    cmd.ExecuteNonQuery();
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static void fb_ZeraQtd()
        {
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "update tb_est_produto set qtd_atual = '0' where qtd_atual != '0'";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    cmd.ExecuteNonQuery();
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }


    }
}