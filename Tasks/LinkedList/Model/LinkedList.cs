
using System.Collections;

namespace LinkedList.Model
{
    public class LinkedList<T> :  IEnumerable
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Count { get; set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        public void Add(T data)
        {
            var item = new Item<T>(data);
            if(Tail != null)//проверяем есть ли в нашем хвосте что-нибудь 
            {
                Tail.Next = item;//зацепляем указатель и привязываем к следующему.
                Tail = item;//и делаем хвост уже этим элементом.
                Count++;
            }
            else// если хвоста нет, то соответсвенно и нет головы
            {
                SetHeadAndTail(data);
            }
        }

        private void SetHeadAndTail(T data)// метод чтобы избежать дублирование кода
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void Delete(T data) // при удалении элемента из списка надо перекинуть указатель на него на след элемент
        {
            if(Head != null) // если наша голова не пустая , то есть идет проверка на случай если список пустой
            {
                if (Head.Data.Equals(data))// если это наш первый элемент(элемент что над удалить), т е голова
                {
                    Head = Head.Next;//надо установить скажем так новую голову,тут мы голове присваиваем след элемент
                    Count--;//уменьшим количество элеметнов в списке
                    return;
                }

                var current = Head.Next;//смотрим на след 
                var previous = Head;//предыдущий элемент
                // а вот тут если наш элемент является не первым
                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        public IEnumerator GetEnumerator()//перечисление всех элементов в списке
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        /// <summary>
        /// Добавить данные в начала списка
        /// </summary>
        /// <param name="data"></param>
        public void AppendHead(T data)
        {
            var item = new Item<T>(data)
            {
                Next = Head
            };

            Head = item;
            Count++;
        }

        /// <summary>
        /// Вставить данные после искомого значения
        /// </summary>
        /// <param name="target"></param>
        /// <param name="data"></param>
        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {
                var current = Head;
                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            else
            {
                // Нужно для себя решить, если список пустой, 
                // то либо не добавлять ничего, либо вставить данные
            }
        }

        /// <summary>
        /// Очистить список
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public override string ToString()
        {
            return "Linked List " + Count + " элементов"; 
        }
    }
}
