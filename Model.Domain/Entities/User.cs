namespace Model.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public int Cpf { get; set; }
    }
}
