using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiControls
{
    public enum EControlLayout { Horizontal, Vertical, Center } 
    public class NumericUpDownControl : ContentView
    {
        #region Bindable Propertys

        public static readonly BindableProperty AcceptButtonIsVisibleProptery =
        BindableProperty.Create(nameof(AcceptButtonIsVisible), typeof(bool), typeof(NumericUpDownControl), false);

        public static readonly BindableProperty ControlLayoutProperty =
        BindableProperty.Create(nameof(ControlLayout), typeof(EControlLayout), typeof(NumericUpDownControl));

        public static readonly BindableProperty CurrentValueChangedCommandProperty =
         BindableProperty.Create(nameof(CurrentValueChangedCommand), typeof(ICommand), typeof(NumericUpDownControl));

        public static readonly BindableProperty AcceptChangesCommandProperty =      
        BindableProperty.Create(nameof(AcceptChangesCommand), typeof(ICommand), typeof(NumericUpDownControl));

        public static readonly BindableProperty StrokeShapeProperty =
        BindableProperty.Create(nameof(StrokeShape), typeof(CornerRadius), typeof(NumericUpDownControl), new CornerRadius(0));

        public static readonly BindableProperty StrokeThicknessProperty =
        BindableProperty.Create(nameof(StrokeThickness), typeof(double), typeof(NumericUpDownControl), 0.0);

        public static readonly BindableProperty CurrentValueProperty =
           BindableProperty.Create(nameof(CurrentValue), typeof(double), typeof(NumericUpDownControl), 20.0, BindingMode.TwoWay);

        public static readonly BindableProperty AcceptButtonImageSourceProperty =       
         BindableProperty.Create(nameof(AcceptButtonImageSource), typeof(ImageSource), typeof(NumericUpDownControl));

        public static readonly BindableProperty UpButtonImageSourceProperty =
          BindableProperty.Create(nameof(UpButtonImageSource), typeof(ImageSource), typeof(NumericUpDownControl));

        public static readonly BindableProperty DownButtonImageSourceProperty =
          BindableProperty.Create(nameof(DownButtonImageSource), typeof(ImageSource), typeof(NumericUpDownControl));

        public static readonly BindableProperty BorderBackgroundColorProperty =
         BindableProperty.Create(nameof(BorderBackgroundColor), typeof(Color), typeof(NumericUpDownControl), Colors.White);

        public static readonly BindableProperty TextColorProperty =
         BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(NumericUpDownControl), Colors.Black);

        public static readonly BindableProperty BorderColorProperty =
        BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(NumericUpDownControl), Colors.White);

        public static readonly BindableProperty FontSizeProperty =
         BindableProperty.Create(nameof(FontSize), typeof(double), typeof(NumericUpDownControl), 20.0);

        public static readonly BindableProperty UpDownButtonImageHeightProperty =
         BindableProperty.Create(nameof(UpDownButtonImageHeight), typeof(double), typeof(NumericUpDownControl), 30.0);

        public static readonly BindableProperty UpDownButtonImageWidthProperty =
        BindableProperty.Create(nameof(UpDownButtonImageWidth), typeof(double), typeof(NumericUpDownControl), 30.0);

        public static readonly BindableProperty AcceptButtonImageHeightProperty =
        BindableProperty.Create(nameof(AcceptButtonImageHeight), typeof(double), typeof(NumericUpDownControl), 30.0);

        public static readonly BindableProperty AcceptButtonImageWidthProperty =
        BindableProperty.Create(nameof(AcceptButtonImageWidth), typeof(double), typeof(NumericUpDownControl), 30.0);

        public static readonly BindableProperty MaxValueProperty =
        BindableProperty.Create(nameof(UpDownButtonImageWidth), typeof(double), typeof(NumericUpDownControl), 100.0);

        public static readonly BindableProperty MinValueProperty =
        BindableProperty.Create(nameof(UpDownButtonImageWidth), typeof(double), typeof(NumericUpDownControl), 9.0);

        public static readonly BindableProperty FontFamilyProperty =
           BindableProperty.Create(nameof(FontFamily), typeof(string), typeof(NumericUpDownControl));


        public NumericUpDownControl()
        {
           InitHorizontalLayout();
        }

        public bool AcceptButtonIsVisible
        {
            get { return (bool)GetValue(AcceptButtonIsVisibleProptery); }
            set { SetValue(AcceptButtonIsVisibleProptery, value); }
        }

        public EControlLayout ControlLayout
        {
            get { return (EControlLayout)GetValue(ControlLayoutProperty); }
            set { SetValue(ControlLayoutProperty, value); }
        }

        public ICommand CurrentValueChangedCommand  
        {
            get { return (ICommand)GetValue(CurrentValueChangedCommandProperty); }
            set { SetValue(CurrentValueChangedCommandProperty, value); }
        }

        public ICommand AcceptChangesCommand
        {
            get { return (ICommand)GetValue(AcceptChangesCommandProperty); }
            set { SetValue(AcceptChangesCommandProperty, value); }
        }

        public CornerRadius StrokeShape
        {
            get { return (CornerRadius)GetValue(StrokeShapeProperty); }
            set { SetValue(StrokeShapeProperty, value); }
        }

        public double StrokeThickness
        {
            get { return (double)GetValue(StrokeThicknessProperty); }
            set { SetValue(StrokeThicknessProperty , value); }
        }
        public string FontFamily
        {
            get { return (string)GetValue(FontFamilyProperty); }
            set { SetValue(FontFamilyProperty, value); }
        }

        public double CurrentValue
        {
            get => (double)GetValue(CurrentValueProperty);
            set => SetValue(CurrentValueProperty, value);
        }

        public double MaxValue
        {
            get => (double)GetValue(MaxValueProperty);
            set => SetValue(MaxValueProperty, value);
        }

        public double MinValue
        {
            get => (double)GetValue(MinValueProperty);
            set => SetValue(CurrentValueProperty, value);
        }

        public ImageSource AcceptButtonImageSource
        {
            get => (ImageSource)GetValue(AcceptButtonImageSourceProperty);
            set => SetValue(AcceptButtonImageSourceProperty, value);
        }

        public ImageSource UpButtonImageSource
        {
            get => (ImageSource)GetValue(UpButtonImageSourceProperty);
            set => SetValue(UpButtonImageSourceProperty, value);
        }

        public ImageSource DownButtonImageSource
        {
            get => (ImageSource)GetValue(DownButtonImageSourceProperty);
            set => SetValue(DownButtonImageSourceProperty, value);
        }

        public Color BorderBackgroundColor  
        {
            get { return (Color)GetValue(BorderBackgroundColorProperty); }
            set { SetValue(BorderBackgroundColorProperty, value); }
        }

        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        public double UpDownButtonImageHeight
        {
            get { return (double)GetValue(UpDownButtonImageHeightProperty); }
            set { SetValue(UpDownButtonImageHeightProperty, value); }
        }

        public double UpDownButtonImageWidth
        {
            get { return (double)GetValue(UpDownButtonImageWidthProperty); }
            set { SetValue(UpDownButtonImageWidthProperty, value); }
        }

        public double AcceptButtonImageHeight
        {
            get { return (double)GetValue(AcceptButtonImageHeightProperty); }
            set { SetValue(AcceptButtonImageHeightProperty, value); }
        }

        public double AcceptButtonImageWidth
        {
            get { return (double)GetValue(AcceptButtonImageWidthProperty); }
            set { SetValue(AcceptButtonImageWidthProperty, value); }
        }
        #endregion

        #region Fields

        private double commandParameter;
        private Border border;
        private HorizontalStackLayout horStack;
        private Grid grid;   
        private Label labelValue;
        private ImageButton upImage;
        private ImageButton downImage;
        private ImageButton acceptImage;
        private ICommand upButtonCommand;
        private ICommand downButtonCommand;
        private ICommand valueChangedCommand;
        private ICommand acceptImageCommand;
        
        #endregion

        #region Overrides
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == null) return; 

            if (propertyName == nameof(CurrentValue))
            {
                this.labelValue.Text = CurrentValue.ToString();
                this.commandParameter = CurrentValue;
                if (ValueChangedCommand != null)
                ValueChangedCommand.Execute(commandParameter);
            }
            if (propertyName == nameof(StrokeShape))
            {
                this.border.StrokeShape = new RoundRectangle { CornerRadius = StrokeShape };
            }
            if (propertyName == nameof(StrokeThickness))
            {
                this.border.StrokeThickness = StrokeThickness;
            }
            if (propertyName == nameof(BorderColor))
            {
                this.border.Stroke = BorderColor;
            }
            if (propertyName == nameof(BorderBackgroundColor))
            {
                this.border.BackgroundColor = BorderBackgroundColor;
            }
            if (propertyName == nameof(HeightRequest))
            {
                this.border.HeightRequest = HeightRequest;
            }
            if (propertyName == nameof(WidthRequest))
            {
                this.border.WidthRequest = WidthRequest;
            }
            if (propertyName == nameof(HorizontalOptions))
            {
                this.border.HorizontalOptions = HorizontalOptions;
            }
            if (propertyName == nameof(VerticalOptions))
            {
                this.border.VerticalOptions = VerticalOptions;
            }
            if (propertyName == nameof(FontSize))
            {
                this.labelValue.FontSize = FontSize != 0.0 ? FontSize : 20.0;
            }
            if (propertyName == nameof(TextColor))
            {
                this.labelValue.TextColor = TextColor;
            }
            if (propertyName == nameof(FontFamily))
            {
                this.labelValue.FontFamily = FontFamily;
            }
            if (propertyName == nameof(UpButtonImageSource))
            {
                this.upImage.Source = UpButtonImageSource != null ? UpButtonImageSource : null;
            }
            if (propertyName == nameof(DownButtonImageSource))
            {
                this.downImage.Source = DownButtonImageSource != null ? DownButtonImageSource : null;
            }
            if (propertyName == nameof(AcceptButtonImageSource))
            {
                if (AcceptButtonIsVisible)
                     this.acceptImage.Source = AcceptButtonImageSource != null ? AcceptButtonImageSource : null;
            }
            if (propertyName == nameof(UpDownButtonImageHeight))
            {
                this.upImage.HeightRequest = UpDownButtonImageHeight != 0.0 ? UpDownButtonImageHeight : 30.0;
                this.downImage.HeightRequest = UpDownButtonImageHeight != 0.0 ? UpDownButtonImageHeight : 30.0;
            }
            if (propertyName == nameof(UpDownButtonImageWidth))
            {
                this.upImage.WidthRequest = UpDownButtonImageWidth != 0.0 ? UpDownButtonImageWidth : 30.0;
                this.downImage.WidthRequest = UpDownButtonImageWidth != 0.0 ? UpDownButtonImageWidth : 30.0;            
            }
            if (propertyName == nameof(AcceptButtonImageHeight))
            {
                this.acceptImage.HeightRequest = AcceptButtonImageHeight != 0.0 ? AcceptButtonImageHeight : 30.0;
            }
            if (propertyName == nameof(AcceptButtonImageWidth))
            {
                this.acceptImage.WidthRequest = AcceptButtonImageWidth != 0.0 ? AcceptButtonImageWidth : 30.0;
            }
            if (propertyName == nameof(ControlLayout))
            {
                switch (ControlLayout)
                {
                    case EControlLayout.Center:  break;
                    case EControlLayout.Vertical: Content = InitVerticalLayout(); SetHorizontalLayoutParents(); break;
                    default: Content = InitHorizontalLayout(); SetHorizontalLayoutParents(); break;
                }
            }
            if (propertyName == nameof(AcceptButtonIsVisible))
            {
                 if (AcceptButtonIsVisible)
                {
                    if (!horStack.Children.Contains(acceptImage))
                    {
                        switch (ControlLayout)
                        {
                            case EControlLayout.Center: break;
                            case EControlLayout.Vertical: grid.Children.Add(acceptImage); Grid.SetColumn(acceptImage, 2); break;
                            default: horStack.Children.Add(acceptImage); break;
                        }
                        
                    }
                }
                else
                {
                    if (horStack.Children.Contains(acceptImage))
                    {
                        switch (ControlLayout)
                        {
                            case EControlLayout.Center: break;
                            case EControlLayout.Vertical: grid.Children.Remove(acceptImage); break;
                            default: horStack.Children.Remove(acceptImage); break;
                        }
                      
                    }
                }
            }
        }


        protected override void OnParentSet()
        {
            base.OnParentSet();

            switch (ControlLayout)
            {
                case EControlLayout.Center: break;
                case EControlLayout.Vertical: Content = InitVerticalLayout(); break;
                default: Content = InitHorizontalLayout(); break;
            }

            SetHorizontalLayoutParents();         
        }
        #endregion

        #region Methods
        private void SetVerticalLayoutParents()
        {

        }

        private void SetCenterLayoutParents()
        {

        }

        private void SetHorizontalLayoutParents()
        {
            this.border.Stroke = BorderColor;
            this.border.StrokeShape = new RoundRectangle { CornerRadius = StrokeShape };
            this.border.StrokeThickness = StrokeThickness;
            this.border.BackgroundColor = BorderBackgroundColor;
            this.border.HeightRequest = HeightRequest;
            this.border.WidthRequest = WidthRequest;
            this.border.HorizontalOptions = HorizontalOptions;
            this.border.VerticalOptions = VerticalOptions;


            this.labelValue.FontSize = FontSize;
            this.labelValue.Text = CurrentValue.ToString();
            this.labelValue.TextColor = TextColor;
            this.labelValue.FontFamily = FontFamily;

            this.upImage.Source = UpButtonImageSource;
            this.upImage.HeightRequest = UpDownButtonImageHeight;
            this.upImage.WidthRequest = UpDownButtonImageWidth;

            this.downImage.Source = DownButtonImageSource;
            this.downImage.HeightRequest = UpDownButtonImageHeight;
            this.downImage.WidthRequest = UpDownButtonImageWidth;

            var acceptImage = new ImageButton
            {
                Aspect = Aspect.AspectFit,
                Margin = new Thickness(4),
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Center,
                Command = AcceptImageCommand
            };
            

           

            if (AcceptButtonIsVisible)
            {
                this.acceptImage = acceptImage;

                this.acceptImage.Source = AcceptButtonImageSource;
                this.acceptImage.HeightRequest = AcceptButtonImageHeight;
                this.acceptImage.WidthRequest = AcceptButtonImageWidth;         

                switch (ControlLayout)
                {
                    case EControlLayout.Vertical: grid.Children.Add(acceptImage); grid.SetColumn(acceptImage, 2); break;
                    case EControlLayout.Center: break;
                    default: horStack.Children.Add(acceptImage); break;
                }
            }
                
                
            
           
            
        }
       
        #region Layouts
        private View InitVerticalLayout()
        {
            var border = new Border();
            this.border = border;

            var grid = new Grid
            {
                //HorizontalOptions = LayoutOptions.Center,
                //VerticalOptions = LayoutOptions.Center,

                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto)},
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto)},
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
                }
            };
            this.grid = grid;

            var labelValue = new Label
            {

                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center

            };
            this.labelValue = labelValue;

            var vertStack = new VerticalStackLayout
            {
                Spacing = 2,
                Margin = new Thickness(4),
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
            };
            

            var upImage = new ImageButton
            {
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
                Command = UpButtonCommand
            };
            this.upImage = upImage;

            var downImage = new ImageButton
            {
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
                Command = DownButtonCommand
            };
            this.downImage = downImage;

            vertStack.Children.Add(upImage);
            vertStack.Children.Add(downImage);
            grid.Children.Add(vertStack);
            grid.Children.Add(labelValue);
            grid.SetColumn(vertStack, 0);
            grid.SetColumn(labelValue, 1);
            border.Content = grid;

            return border;
        }
        private void InitCenterLayout()
        {

        }
        private View InitHorizontalLayout()
        {
            var border = new Border();
            this.border = border;

            var horStack = new HorizontalStackLayout
            {
                Spacing = 10,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };
            this.horStack = horStack;
            

            var labelValue = new Label
            {

                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center

            };
            this.labelValue = labelValue;


            var upImage = new ImageButton
            {
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Command = UpButtonCommand
            };
            this.upImage = upImage;

            var downImage = new ImageButton
            {
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Command = DownButtonCommand
            };
            this.downImage = downImage;

           

            horStack.Children.Add(labelValue);
            horStack.Children.Add(upImage);
            horStack.Children.Add(downImage);
            
          
            border.Content = horStack;

            return border;
        }

        #endregion
        #endregion
        #region Commands
        public ICommand UpButtonCommand =>
          upButtonCommand
          ?? (upButtonCommand = new Command(() => UpButtonAction()));
        private void UpButtonAction()   
        {
            Application.Current.Dispatcher.Dispatch(async () =>
            {
                await upImage.ScaleTo(0.8, 70, Easing.Linear);

                if (CurrentValue < MaxValue)
                    CurrentValue++;

                await Task.Delay(40);
                await upImage.ScaleTo(1, 70, Easing.Linear);

            });
           
        }

        public ICommand DownButtonCommand =>
          downButtonCommand
          ?? (downButtonCommand = new Command(() => DownButtonAction()));
        private void DownButtonAction() 
        {
            Application.Current.Dispatcher.Dispatch(async () =>
            {
                await downImage.ScaleTo(0.8, 70, Easing.Linear);

                if (CurrentValue > MinValue)
                    CurrentValue--;

                await Task.Delay(40);
                await downImage.ScaleTo(1, 70, Easing.Linear);

            });
           
        }

        public ICommand ValueChangedCommand =>
         valueChangedCommand
         ?? (valueChangedCommand = new Command(() => ValueChangedAction()));
        private void ValueChangedAction()   
        {
            if (!IsEnabled)
                return;

            Application.Current.Dispatcher.Dispatch(() =>
            {
                if (CurrentValueChangedCommand != null)
                     CurrentValueChangedCommand.Execute(commandParameter);
            });
        }

        public ICommand AcceptImageCommand =>
        acceptImageCommand
        ?? (acceptImageCommand = new Command(() => AcceptImageAction()));

        private void AcceptImageAction()
        {
            if (!IsEnabled)
                return;

            Application.Current.Dispatcher.Dispatch(async () =>
            {
                await border.ScaleTo(0.8, 70, Easing.Linear);

                if (AcceptChangesCommand != null)
                {
                    AcceptChangesCommand.Execute(null);

                }
                await Task.Delay(40);
                await border.ScaleTo(1, 70, Easing.Linear);

            });
        }
        #endregion
    }
}
