### About

Simple demo showcasing the MVVM pattern using basic building blocks such as `ObservableObject <INotifyPropertyChanged>` and `RelayCommand <ICommand>` 
provided by MicroMvvm project.


### Project file structure

All MVVM/XAML applications should have a similiar directory structure. The following tree shows a possible structure.

- **Model**: Model and domain clasess.
- **ViewModel**: View models clasess.
    - *Examples*:
	- MainWindowModel.cs
	- MyViewModel.cs
		- **Dialog**
			- SelectItemDialogModel.cs
- **View**: Contains the views.
    - *Examples*:
	- MainWindow.xaml
	- MyView.xaml
	- **Dialog**
		- SelectItemDialog.xaml

As shown in the list, the name of a view should end with its type:

* **Window**: A non-modal window.
* **Dialog**: A (modal) dialog window.
* **Page**: A page view (mostly used in Windows Phone and Windows Store apps).
* **View**: A view which is used as subview in another view, page, window or dialog.

*Source*: [Project file structure recomendation](http://blog.rsuter.com/recommendations-best-practices-implementing-mvvm-xaml-net-applications)

### Guidelines & naming style

The name of a view model should be composed of the corresponding view’s name and the word “Model”. 
The view models are stored in the same location in the ViewModel directory as their corresponding views in the View directory.

1. Separate folders for Model, View and ViewModel.
2. Append *View* to Views.
3. Append *ViewModel* to ViewModels.

### Definitions

- **View**: Represents the UI.
- **ViewModel**: Gets the Model to the View.
- **Model**: Business entity.

### Dependencies

**MicroMvvm** project original author (2012-10-10): Barry Lapthorn  
*Source*: [Code Project](http://www.codeproject.com/Articles/165368/WPF-MVVM-Quick-Start-Tutorial)

2016-08-30