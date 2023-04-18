namespace ObjetosDuplicados
{
    public class CompareObjects : IEqualityComparer<Objetos>
    {
        public bool Equals(Objetos one, Objetos two)
        {
            return string.Equals(one.Name.Trim(), two.Name.Trim(), StringComparison.CurrentCultureIgnoreCase)
            && string.Equals(one.Description.Trim(), two.Description.Trim(), StringComparison.CurrentCultureIgnoreCase);
        }

        public int GetHashCode(Objetos obj)
        {
            if (ReferenceEquals(obj, null)) return 0;
            var hashCodeName = obj.Name == null ? 0 : obj.Name.GetHashCode();
            var hashCodeDesc = obj.Description == null ? 0 : obj.Description.GetHashCode();
            return hashCodeName ^ hashCodeDesc;
        }
    }

    public class Objetos
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Objetos(string nome, string desc)
        {
            Name = nome; Description = desc;
        }
    }
}