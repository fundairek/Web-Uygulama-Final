using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;

namespace PojeFinal.Models
{
    [Serializable]
    public class Musteri
    {
        public virtual int Id { get; set; }
        public virtual string Ad { get; set; }

        public virtual string Soyad { get; set; }
        public virtual string Sube  { get; set; }
        public virtual string Sehir { get; set; }
        public virtual string Telefon { get; set; }

        public virtual ICollection<Sıparis> Subeler { get; set; } = new List<Sıparis>();

    }

   
    public class BankaMap : ClassMapping<Musteri>
    {
        public BankaMap()
        {
            Table("Musteri");
            Id(x => x.Id, m => m.Generator(Generators.Native));
            Property(x => x.Ad, c => c.Length(20));
            Property(x => x.Soyad, c => c.Length(20));
            Property(x => x.Sube, c => c.Length(20));
            Property(x => x.Sehir, c => c.Length(30));
            Property(x => x.Telefon, c => c.Length(20));
           
            Set(e => e.Subeler,
               mapper =>
               {
                   mapper.Key(k => k.Column("Musteri"));
                   mapper.Inverse(true);
                   mapper.Cascade(Cascade.All);
               },
              relation => relation.OneToMany(mapping => mapping.Class(typeof(Sıparis))));

        }
    }
}