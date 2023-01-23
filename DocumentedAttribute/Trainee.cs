
namespace DocumentedAttribute
{
    [Document("This class represents a trainee in a training program.", Input = "Name, Age, Level", Output = "Name, Age, Level")]
    public class Trainee
    {
        [Document("This is the name property of the trainee")]
        public string Name { get; set; }

        [Document("This is the age property of the trainee")]
        public int Age { get; set; }

        [Document("The level of the trainee in the training program")]
        public string Level { get; set; }


        [Document("This method gets a trainee name in a training program.", Input = "", Output = "Intermediate level trained Trainee")]
        public void GetName()
        {
            //
        }
    }
}
