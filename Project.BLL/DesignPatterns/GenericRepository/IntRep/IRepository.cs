using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {
        //ListCommands
        List<T> GetAll();
        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetModifieds();

        T GetById(int id);

        //Modifications
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        string Destroy(T entity);

        //Expressions

        // Bir ifade tipinde icerisine Func seklinde T tipi ne ise onu alip verdigimiz  bool  ifadeye gore sorgulasin sorguladigi seylerde olumlu donenleri kume olarak alsin ve geriye sonuc olarak dondurme gorevini yapan delegate ekle. 
        List<T> Where(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        object Select(Expression<Func<T, dynamic>> exp);
        List<X> Select<X>(Expression<Func<T, X>> exp);
    }
}
