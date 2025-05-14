using lab4.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab4.Controllers
{
    public class BlqhBookController : Controller 
    {
        List<BlqhBook> blqhbooks = new List<BlqhBook>
        {
            new BlqhBook
            {
                BlqhId = "B001",
                BlqhTitle = "The Art of Code",
                BlqhDescription = "A deep dive into the elegance and philosophy of programming.",
                BlqhImage = "image1.jpg",
                BlqhPrice = 29.99f,
                BlqhPage = 320
            },
            new BlqhBook
            {
                BlqhId = "B002",
                BlqhTitle = "C# in Depth",
                BlqhDescription = "Comprehensive guide to mastering C# programming language.",
                BlqhImage = "image2.jpg",
                BlqhPrice = 35.50f,
                BlqhPage = 450
            },
            new BlqhBook
            {
                BlqhId = "B003",
                BlqhTitle = "Clean Architecture",
                BlqhDescription = "A practical guide to software structure and design principles.",
                BlqhImage = "image3.jpg",
                BlqhPrice = 40.00f,
                BlqhPage = 380
            },
            new BlqhBook
            {
                BlqhId = "B004",
                BlqhTitle = "The Pragmatic Programmer",
                BlqhDescription = "Timeless tips for becoming a better software developer.",
                BlqhImage = "image4.jpg",
                BlqhPrice = 42.00f,
                BlqhPage = 400
            },
            new BlqhBook
            {
                BlqhId = "B005",
                BlqhTitle = "Design Patterns Explained",
                BlqhDescription = "Simplified guide to understanding software design patterns.",
                BlqhImage = "image5.jpg",
                BlqhPrice = 33.75f,
                BlqhPage = 290
            }
        };

    } 
        public IActionResult BlqhIndex()
        {

            return View(blqhbooks);
        }
        public IActionResult BlqhCreate()
        {
            BlqhBook book = new BlqhBook();
            return View(book); // Gửi form rỗng
        }

        [HttpPost]
        public IActionResult BlqhCreateSubmit(BlqhBook book)
        {
            blqhbooks.Add(book); // thêm vào danh sách
            return RedirectToAction("BlqhIndex");
        }

        public IActionResult BlqhEdit(string id)
        {
            var book = blqhbooks.FirstOrDefault(b => b.BlqhId == id);
            if (book == null) return NotFound();
            return View(book);
        }

        [HttpPost]
        public IActionResult BlqhEditSubmit(BlqhBook updatedBook)
        {
            var book = blqhbooks.FirstOrDefault(b => b.BlqhId == updatedBook.BlqhId);
            if (book != null)
            {
                book.BlqhTitle = updatedBook.BlqhTitle;
                book.BlqhDescription = updatedBook.BlqhDescription;
                book.BlqhImage = updatedBook.BlqhImage;
                book.BlqhPrice = updatedBook.BlqhPrice;
                book.BlqhPage = updatedBook.BlqhPage;
            }
            return RedirectToAction("BlqhIndex");
        }
        public IActionResult BlqhDelete(string id)
        {
            var book = blqhbooks.FirstOrDefault(b => b.BlqhId == id);
            if (book != null)
            {
                blqhbooks.Remove(book);
            }
            return RedirectToAction("BlqhIndex");

        }
