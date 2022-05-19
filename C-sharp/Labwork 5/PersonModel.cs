namespace Labwork_5
{
    public class PersonModel
    {
        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set 
            {
                Validator.ValidateName(value);
                _firstName = value;
            }
        }
        private string _secondName;
        public string SecondName
        {
            get => _secondName;
            set 
            { 
                Validator.ValidateName(value);
                _secondName = value; 
            }
        }
        private string _patronymic;
        public string Patronymic
        {
            get => _patronymic;
            set 
            { 
                Validator.ValidateName(value);
                _patronymic = value;
            }
        }
        

        public PersonModel(string firstName, string secondName, string patronymic)
        {
            FirstName = firstName;
            SecondName = secondName;
            Patronymic = patronymic;
        }

        public PersonModel()
        {
            
        }

        public override string ToString()
        {
            return $"First Name - {FirstName}, Second Name - {SecondName}, Patronymic - {Patronymic}";
        }
    }
}