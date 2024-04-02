namespace PropertyTask.Models
{
    class Product
    {
		private string _name = "Elanın adı";
		public string Name
		{
            get => _name.Substring(2);
            set
            { 
				if (value.Length < 65) 
					_name = value;
				else
                    Console.WriteLine("Elan adının uzunluğu 64 simvoldan çox ola bilməz");
			}
        }
		private float _price;
		public float Price
		{
			get => _price;
			set 
			{
                if (value >= 0)
                {
					_price = value;
                }
				else
				{
                    Console.WriteLine("Qiymət düzgün daxil edilməyib.");
                }
            }
		}
		private string _description;
		public string Description
		{
			get { return _description; }
			set
            {
                if (value.Length < 1024)
                    _name = value;
                else
                    Console.WriteLine("Elan adının uzunluğu 64 simvoldan çox ola bilməz");
            }
        }
        public bool IsNew { get; set; }
    }
}
