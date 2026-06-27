namespace AraBirimler
{
    class KisiManager
    {
        IKisi _kisi;

        //dependency Injection:Bağımlılığı Dışarında Veriyoruz
        public KisiManager(IKisi k)
        {
            _kisi = k;
            _kisi.MaasAl(1000);
            _kisi.OdemeYap(250);
        }

        public int KalanPara()
        {
            return _kisi.Cuzdan;
        }
    }
}
