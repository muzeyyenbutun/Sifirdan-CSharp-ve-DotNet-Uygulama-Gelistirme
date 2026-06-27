namespace Paketleme
{
    class ProgramlamaDilleri
    {
        private string programlamadiladi;
        public string ProgramlamaDilAdi
        {
            get { return programlamadiladi; }
            set { programlamadiladi = value; }
        }

        public void Yazdir()
        {
            Console.WriteLine("Programlama Dil Adı    : " + programlamadiladi);
        }
    }
}
