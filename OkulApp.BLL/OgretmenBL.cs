using DAL;
using OkulApp.MODEL;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;


namespace OkulApp.BLL//Bussiness Logic Layer
{
    public class OgretmenBL
    {
        public bool OgretmenEkle(Ogretmen ogretmen)
        {
            try
            {
                SqlParameter[] p = {
                                  new SqlParameter("@OgretmenAd",ogretmen.Ad),
                                  new SqlParameter("@OgretmenSoyad",ogretmen.Soyad),
                                  new SqlParameter("@OgretmenTc",ogretmen.TC)
                            };

                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into Ogretmenler  values (@OgretmenAd,@OgretmenSoyad,@OgretmenTc)", p) > 0;
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                //if (cn != null && cn.State != ConnectionState.Closed)
                // {
                //     cn.Close();
                //    cn.Dispose();

                //    cmd.Dispose();
                //}
            }
        }


    }
}
