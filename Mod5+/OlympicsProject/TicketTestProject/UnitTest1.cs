
namespace TicketTestProject
{
    public class UnitTest1
    {
        public Ticket TestTicket = new Ticket();

        [Fact]
        public void DescriptionTests()
        {
            TestTicket.Description = "Description";
            Assert.Equal("Description", TestTicket.Description);
            Assert.IsType<string>(TestTicket.Description); 
        }

        [Fact]
        public void NameTests()
        {
            TestTicket.TicketName = "Name";
            Assert.Equal("Name", TestTicket.TicketName);
            Assert.IsType<string>(TestTicket.TicketName);
        }

        [Fact]
        public void PointTests()
        {
            TestTicket.PointValue = 4;

            Assert.Equal(4, TestTicket.PointValue);
            Assert.IsType<int>(TestTicket.PointValue);
        }

        [Fact]
        public void SprintTest()
        {
            TestTicket.SprintNumber = 1;

            Assert.Equal(1, TestTicket.SprintNumber);
            Assert.IsType<int>(TestTicket.SprintNumber);
        }

        [Fact]
        public void StatusTest()
        {
            TestTicket.Status = "In Progress";

            bool FactCheck = false;

            for (var i = 0; i < TestTicket.ValidStatus.Count;  i++)
            {
                if (TestTicket.Status == TestTicket.ValidStatus[i])
                {
                    FactCheck = true;
                    break;
                }
            }

            Assert.True(FactCheck);
            Assert.Equal("In Progress", TestTicket.Status);
            Assert.IsType<string>(TestTicket.Status);
        }
    }
}