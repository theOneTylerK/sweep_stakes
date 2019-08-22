using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            SweepstakesManagementFactory SMF = new SweepstakesManagementFactory();
            MarketingFirm mf = new MarketingFirm(SMF.ChooseManagementStyle());

            mf.CreateSweepstakes();
            mf.FinishSweepstakes();
        }
    }
}
