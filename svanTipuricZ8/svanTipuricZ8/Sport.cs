using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svanTipuricZ8
{
    public class Sport
    {
        private string Naziv;
        private bool IgraLiSeLoptom;
        private byte BrojIgraca;

        public Sport() 
        { 
        }
        public Sport(string Naziv)
        {
            this.Naziv = Naziv;
        }
        public Sport(string Naziv,bool IgraLiSeLoptom)
        {
            this.Naziv = Naziv;
            this.IgraLiSeLoptom = IgraLiSeLoptom;
        }
        public Sport(string Naziv,bool IgraLiSeLoptom,byte BrojIgraca)
        {
            this.Naziv = Naziv;
            this.IgraLiSeLoptom = IgraLiSeLoptom;
            this.BrojIgraca = BrojIgraca;
        }
    }
}
