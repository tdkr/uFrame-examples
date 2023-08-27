using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using uFrame.Kernel.Collection;

using UniRx;
namespace uFrame.MVVM.ViewModels
{

public class ModelCollection<T> : ObservableCollection<T>
    , IObservable<uFrame.Kernel.Collection.NotifyCollectionChangedEventArgs>,IObservableProperty
{
    public ModelCollection(ViewModel owner, string propertyName)
    {
        Owner = owner;
        PropertyName = propertyName;
    }

    public ModelCollection()
    {
    }

    public IDisposable Subscribe(IObserver<uFrame.Kernel.Collection.NotifyCollectionChangedEventArgs> observer)
    {
        uFrame.Kernel.Collection.NotifyCollectionChangedEventHandler evt = (sender,args) => observer.OnNext(args);

        CollectionChanged += evt;
        return Disposable.Create(() => CollectionChanged -= evt);
    }

    public object ObjectValue
    {
        get { return this; }
        set {  }
    }

    public string PropertyName { get; set; }
    public ViewModel Owner { get; set; }

    public Type ValueType
    {
        get
        {
            return typeof (ICollection<T>);
        }
    }

    public IObservable<Unit> AsUnit
    {
        get { return Observable.Select(this, _ => Unit.Default); }
    }

    public IDisposable SubscribeInternal(Action<object> propertyChanged)
    {
        return this.Subscribe((v) => { propertyChanged(v); });
    }

    public void AddRange(IEnumerable<T> enumerable)
    {
        foreach (var item in enumerable)
            Add(item);
    }
}
}
