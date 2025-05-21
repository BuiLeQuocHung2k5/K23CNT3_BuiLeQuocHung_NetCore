using BlqhLesson05.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace BlqhLesson05.Controllers
{
    public class BlqhMemberController : Controller
    {
        private static List<BlqhMember> blqhListMembers = new List<BlqhMember>()
        {
            new BlqhMember {
                        BlqhMemberId = "2310900043",
                        BlqhUserName = "BLQHung",
                        BlqhPassword = "pass1",
                        BlqhFullname = "Bùi Lê Quốc Hùng",
                        BlqhEmail = "quochungb3@gmail.com"
                    },
            new BlqhMember{
                        BlqhMemberId = "2",
                        BlqhUserName = "user2",
                        BlqhPassword = "pass2",
                        BlqhFullname = "Nguyen Van A",
                        BlqhEmail = "user2@example.com"
                    },
            new BlqhMember{
                        BlqhMemberId = "3",
                        BlqhUserName = "user3",
                        BlqhPassword = "pass3",
                        BlqhFullname = "Nguyen Van B",
                        BlqhEmail = "user3@example.com"
                    },
             new BlqhMember{
                        BlqhMemberId = "4",
                        BlqhUserName = "user4",
                        BlqhPassword = "pass4",
                        BlqhFullname = "Nguyen Van C",
                        BlqhEmail = "user4@example.com"
                    },
             new BlqhMember {
                        BlqhMemberId = "5",
                        BlqhUserName = "user5",
                        BlqhPassword = "pass5",
                        BlqhFullname = "Nguyen Van C",
                        BlqhEmail = "user5@example@gmail.com"
                    }
        };
        public IActionResult BlqhIndex() //list member
        {
            return View(blqhListMembers);
        }
    }
}
