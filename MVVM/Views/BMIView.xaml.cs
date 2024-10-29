namespace BMIanime.MVVM.Views;
using BMIanime.MVVM.ViewModels;
using Microsoft.Maui.Controls;

public partial class BMIView : ContentPage
{
	double initialRotation, maxRotation;
	public BMIView()
	{
		InitializeComponent();
		BindingContext = new BMIViewModel();
		initialRotation = sword.Rotation;
		maxRotation = 280;
		sword.Rotation = initialRotation + RotateAt();
	}

    private void Pointer_ValueChanged(object sender, Syncfusion.Maui.Gauges.ValueChangedEventArgs e)
    {
		sword.Rotation = initialRotation + RotateAt();
		double curr = sword.Rotation;
    }

	private double RotateAt()
	{
		double pointer = 0;
		double rotationPercentage = 0;

        if (Pointer.Value <= 50)
		{
			pointer = Pointer.Value;
            rotationPercentage = pointer / 50;
        }
		else
		{
			pointer = 50;
            rotationPercentage = pointer / 50;
        }
		
		return maxRotation * rotationPercentage;
	}
}