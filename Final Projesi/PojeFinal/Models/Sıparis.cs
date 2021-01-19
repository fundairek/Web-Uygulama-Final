using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PojeFinal.Models
{
    public class Sıparis
    {
        public virtual int Id { get; set; }
        public virtual string Ad { get; set; }

        public virtual string Soyad{ get; set; }
        public virtual string Telefon { get; set; }

      
        public virtual Musteri Musteri { get; set; }
    }

    public class SubeMap : ClassMapping<Sıparis>
    {
        public SubeMap()
        {
            Table("Sıparıs");
            Id(x => x.Id, m => m.Generator(Generators.Native));
            Property(x => x.Ad, c => c.Length(20));
            Property(x => x.Soyad, c => c.Length(20));
            Property(x => x.Telefon, c => c.Length(20));
            Property(x => x.Musteri, c => c.Length(20));
            ManyToOne(x => x.Musteri);
        }
    }
}