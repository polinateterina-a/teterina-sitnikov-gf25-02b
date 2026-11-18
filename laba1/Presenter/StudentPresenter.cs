using System.Collections.Generic;
using System.Linq;
using Model;
using WinFormView;

namespace Presenter;

public class StudentPresenter
{
    private readonly IModel<Student> model;
    private readonly IView view;

    public StudentPresenter(IModel<Student> model, IView view)
    {
        this.model = model;
        this.view = view;

        
        model.DataChanged += view.RedrawForm;      
        view.AddDataEvent += OnAddData;            
        view.DeleteDataEvent += OnDeleteData;
    }

    private void OnAddData(IEnumerable<object> data)
    {
        var p = data.ToList();
        var student = new Student
        {
            Name = (string)p[0],
            Speciality = (string)p[1],
            Group = (string)p[2]
        };

        if (!model.Insert(student, out string? error))
        {
            view.ShowMessage(error!, "Ошибка", true);
        }
    }

    private void OnDeleteData(int index)
    {
        if (index < 0)
            view.ShowMessage("Выберите студента.", "Удаление", true);
        else if (model.Delete(index))
            view.ShowMessage("Студент удалён.", "Удаление", false);
        else
            view.ShowMessage("Не удалось удалить студента.", "Ошибка", true);
    }
}