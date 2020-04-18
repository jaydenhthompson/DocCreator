namespace DocCreator
{
    public class Config
    {
        public string imageFolderPath { get; set; }
        public string existingDocPath { get; set; }

        public Margin margins { get; set; }

        public Config() 
        {
            margins = new Margin();
        }

    }

    public class Margin
    {
        public float right { get; set; }
        public float left { get; set; }
        public float top { get; set; }
        public float bottom { get; set; }

        public Margin()
        {
            this.right  = 1;
            this.left   = 1;
            this.top    = 1;
            this.bottom = 1;
        }
    }
}
