using System.Linq;
using System.Web;
using System.IO;
using System.Collections.Generic;

namespace ClassLibraryEF.Services
{
    public class NewsDBProvider
    {
        emploeeEF db = new emploeeEF();
        public IEnumerable<ContentTable> Index()
        {
            return db.ContentTables;
        }
        public void Delete(int id)
        {
            ContentTable contentTable = db.ContentTables.Find(id);
            db.ContentTables.Remove(contentTable);
            db.SaveChanges();
        }

        public ContentTable Add(ContentTable contentTable, HttpPostedFileBase uploadImage)
        {
            if (uploadImage != null)
            {
                byte[] imageData = null;
                using (var binaryReader = new BinaryReader(uploadImage.InputStream))
                {
                    imageData = binaryReader.ReadBytes(uploadImage.ContentLength);
                }
                contentTable.ImagePath = imageData;
                db.ContentTables.Add(contentTable);
                db.SaveChanges();
            }
            return contentTable;
        }

        public IEnumerable<ContentTable> Hockey()
        {
            return db.ContentTables.Where(u => (u.IdSport == 2));
        }
        public IEnumerable<ContentTable> Football()
        {
            return db.ContentTables.Where(u => (u.IdSport == 1));
        }
        public IEnumerable<ContentTable> Box()
        {
            return db.ContentTables.Where(u => (u.IdSport == 3));
        }

        public void DeleteArticle(int id)
        {
            ContentTable contentTable = db.ContentTables.Find(id);
            db.ContentTables.Remove(contentTable);
            db.SaveChanges();
        }

        public ContentTable GetDelete(int? id)
        {
            return db.ContentTables.Find(id);
        }
    }
}
