namespace AraBirimler
{
    interface IKisi
    {
        string AdiSoyadi { get; set; }
        int Cuzdan { get; set; } //property:özellik
        void MaasAl(int para); //metod
        int OdemeYap(int para);

    }
    class Ogrenci : IKisi
    {
        public string Okul { get; set; }
        public string AdiSoyadi { get; set; }
        public int Cuzdan { get; set; }

        public void MaasAl(int para)
        {
            Cuzdan = Cuzdan + para;
        }

        public int OdemeYap(int para)
        {
            if (Cuzdan >= para)
            {
                Cuzdan = Cuzdan - para;
            }
            return Cuzdan;
        }
    }
    class Personel : IKisi
    {
        public string CalistigiYer { get; set; }
        public string AdiSoyadi { get; set; }
        public int Cuzdan { get; set; }

        public void MaasAl(int para)
        {
            Cuzdan = Cuzdan + para - (para * 15 / 100);
        }

        public int OdemeYap(int para)
        {
            Cuzdan = Cuzdan - para;
            return Cuzdan;
        }
    }
}
