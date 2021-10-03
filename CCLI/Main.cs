using System;

namespace CCLI
{
    public class CommandLine
    {
        private static DoubleBufferedVMWareSVGAII driver = null;
        public CommandLine()
        {
            driver = new DoubleBufferedVMWareSVGAII();
            driver.SetMode(640, 480);         
        }

        
    }
}
