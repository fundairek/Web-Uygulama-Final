using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PojeFinal.Controllers
{
    public class OgrenciController : Controller
    {



        public ActionResult Listele2()
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                //var siparis = session.Get<Models.Sıparıs>(1);
                /*
                var müsteri1 = session.Query<Models.Musteri>().Where(x=> x.Id==1).FirstOrDefault(); ;
                var siparis = new Models.Sıparıs();
                siparis.Ad = "Maltepe";
                 siparis.Telefon = "25869336";

                var mst = session.Query<Models.Musteri>().Where(x => x.Ad == "Evrim").FirstOrDefault();
               
               siparis.Musteri =  siparis;
                session.SaveOrUpdate(siparis);
                */

                var siparisekle = new Models.Musteri() { Ad = "Güney Sarı",Soyad="Sarı",Sube="Bornova",Sehir = "İzmir", Telefon = "125778669" };
                var siparis = new Models.Sıparıs();
                siparis.Ad = "Tayfun";
                siparis.Telefon = "36582147";
                siparisekle.Subeler.Add(siparis);
                session.SaveOrUpdate(siparisekle);
                session.Flush();
                //var siparisT = session.Query<Models.Musteri>().Where(x => x.Ad == "Murat");

                //  siparis.Musteri =  siparis;
                //  session.SaveOrUpdate(siparis);



                //var t = siparis.Subeler;
                //siparis.Ad = "Merve";
                //siparis.Telefon = "12545667899";


                //  var siparisL = session.Query<Models.Musteri>().Where(x => x.Sehir == "Ankara").ToList();

                /*   var siparisL = new Models.Musteri(){

                        Ad = "Neslihan",
                        Soyad="Mutlu"
                        Telefon = "259638741",
                        Sehir = "Malatya"

                    };

                   */


                // var  siparisL= session.Query<Models.Sıparıs>().FirstOrDefault(x => x.Id == 6);
                //session.SaveOrUpdate( siparisL);

                //session.Delete(siparisL);
                // session.Flush();

            }


            return View(Models.OgrenciVeri.VeriListe);
        }




    }
}