namespace Store
{
    public class Good
    {
        private readonly string _name;

        public Good(string name)
        {
            _name = name;
        }

        public string Name => _name;
    }
}