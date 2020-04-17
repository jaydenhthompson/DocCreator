namespace DocCreator
{
    class Config
    {
        public string imageFolderPath { get; set; }
        public string existingDocPath { get; set; }

        public Margin margins { get; set; }

    }

    class Margin
    {
        public float right { get; set; }
        public float left { get; set; }
        public float top { get; set; }
        public float bottom { get; set; }
    }
}
