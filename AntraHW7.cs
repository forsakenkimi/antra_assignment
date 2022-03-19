using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{

//    1.
//code redundency

//2.
//List<string> list = new List<string>();

//3.
//2 <TKey, TValue>

//4.
//F

//5.
//.Add()

//6.
//.remove(), .clear()

//7.
//<T> after class name

//8.
//F

//9.
//T

//10.
//F

    //public class CustomStack<T>
    //{
    //    public List<T> list = new List<T>();

    //    public int Count()
    //    {
    //        return list.Count;
    //    }

    //    public T Pop()
    //    {
    //        int n = Count();
    //        T obj = list[n];
    //        list.RemoveAt(n);
    //        return obj;
    //    }

    //    public void push(T obj)
    //    {
    //        list.Add(obj);
    //    }

    //}

    //public class MyList<T>
    //{
    //    public List<T> list  = new List<T>();

    //    public void Add (T element)
    //    {
    //        list.Add (element);
    //    }

    //    public T Remove(int idx)
    //    {
    //        T obj = list[idx];
    //        list.RemoveAt (idx);
    //        return obj;
    //    }

    //    public bool Contains(T element)
    //    {
    //        for (int i = 0; i < list.Count; i++)
    //        {
    //            if (list[i].Equals(element))
    //            {
    //                return true;
    //            }
    //        }
    //        return false;
    //    }

    //    public void Clear()
    //    {
    //        list.Clear();
    //    }

    //    public void InsertAt(T element, int idx)
    //    {
    //        list.Insert(idx, element);
    //    }

    //    public void DeleteAt(int index)
    //    {
    //        list.RemoveAt(index);
    //    }

    //    public T Find(int idx)
    //    {
    //        return list[idx];
    //    }
    //}


    //public interface Irepository<T>
    //{
    //    public int Id { get; set; }

    //    void Add(T item);

    //    void Remove(T item);

    //    void Save();

    //    T GetById(int id);

    //    IEnumerable<T> GetAll();
    //}

    //public class GenericRepository<T> : Irepository<T> where T : class
    //{
    //    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //    public void Add(T item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<T> GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public T GetById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Remove(T item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Save()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
