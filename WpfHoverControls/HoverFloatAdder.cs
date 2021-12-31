using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfHoverControls
{
    /// <summary>
    /// Realice los pasos 1a o 1b y luego 2 para usar este control personalizado en un archivo XAML.
    ///
    /// Paso 1a) Usar este control personalizado en un archivo XAML existente en el proyecto actual.
    /// Agregue este atributo XmlNamespace al elemento raíz del archivo de marcado en el que 
    /// se va a utilizar:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfHoverControls"
    ///
    ///
    /// Paso 1b) Usar este control personalizado en un archivo XAML existente en otro proyecto.
    /// Agregue este atributo XmlNamespace al elemento raíz del archivo de marcado en el que 
    /// se va a utilizar:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfHoverControls;assembly=WpfHoverControls"
    ///
    /// Tendrá también que agregar una referencia de proyecto desde el proyecto en el que reside el archivo XAML
    /// hasta este proyecto y recompilar para evitar errores de compilación:
    ///
    ///     Haga clic con el botón secundario del mouse en el proyecto de destino en el Explorador de soluciones y seleccione
    ///     "Agregar referencia"->"Proyectos"->[Busque y seleccione este proyecto]
    ///
    ///
    /// Paso 2)
    /// Prosiga y utilice el control en el archivo XAML.
    ///
    ///     <MyNamespace:HoverFloatAdder/>
    ///
    /// </summary>
    public class HoverFloatAdder : Control
    {
        static HoverFloatAdder()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HoverFloatAdder), new FrameworkPropertyMetadata(typeof(HoverFloatAdder)));
        }


        public event EventHandler OnValueChanged;

        #region CornerRadius
        
        [Category("Hover Float Adder")]
        public CornerRadius LeftButtonCornerRadius
        {
            get { return (CornerRadius)GetValue(LeftButtonCornerRadiusProperty); }
            set { SetValue(LeftButtonCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LeftButtonCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LeftButtonCornerRadiusProperty =
            DependencyProperty.Register("LeftButtonCornerRadius", typeof(CornerRadius), typeof(HoverFloatAdder), new PropertyMetadata(new CornerRadius(5, 0, 0, 5)));

        [Category("Hover Float Adder")]
        public CornerRadius RightButtonCornerRadius
        {
            get { return (CornerRadius)GetValue(RightButtonCornerRadiusProperty); }
            set { SetValue(RightButtonCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RightButtonCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RightButtonCornerRadiusProperty =
            DependencyProperty.Register("RightButtonCornerRadius", typeof(CornerRadius), typeof(HoverFloatAdder), new PropertyMetadata(new CornerRadius(0, 5, 5, 0)));

        [Category("Hover Float Adder")]
        public CornerRadius TextBoxCornerRadius
        {
            get { return (CornerRadius)GetValue(TextBoxCornerRadiusProperty); }
            set { SetValue(TextBoxCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextBoxCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextBoxCornerRadiusProperty =
            DependencyProperty.Register("TextBoxCornerRadius", typeof(CornerRadius), typeof(HoverFloatAdder), new PropertyMetadata(new CornerRadius(0)));

        #endregion

        #region Brushes

        [Category("Hover Float Adder")]
        public Brush ButtonBrush
        {
            get { return (Brush)GetValue(ButtonBrushProperty); }
            set { SetValue(ButtonBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonBrushProperty =
            DependencyProperty.Register("ButtonBrush", typeof(Brush), typeof(HoverFloatAdder), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(80, 80, 80))));

        [Category("Hover Float Adder")]
        public Brush ButtonHoverBrush
        {
            get { return (Brush)GetValue(ButtonHoverBrushProperty); }
            set { SetValue(ButtonHoverBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonHoverBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonHoverBrushProperty =
            DependencyProperty.Register("ButtonHoverBrush", typeof(Brush), typeof(HoverFloatAdder), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(100, 100, 100))));

        [Category("Hover Float Adder")]
        public Brush TextBoxBrush
        {
            get { return (Brush)GetValue(TextBoxBrushProperty); }
            set { SetValue(TextBoxBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextBoxBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextBoxBrushProperty =
            DependencyProperty.Register("TextBoxBrush", typeof(Brush), typeof(HoverFloatAdder), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(60, 60, 60))));

        [Category("Hover Float Adder")]
        public Brush TextBoxHoverBrush
        {
            get { return (Brush)GetValue(TextBoxHoverBrushProperty); }
            set { SetValue(TextBoxHoverBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextBoxHoverBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextBoxHoverBrushProperty =
            DependencyProperty.Register("TextBoxHoverBrush", typeof(Brush), typeof(HoverFloatAdder), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(70, 70, 70))));

        [Category("Hover Float Adder")]
        public Brush IconBrush
        {
            get { return (Brush)GetValue(IconBrushProperty); }
            set { SetValue(IconBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconBrushProperty =
            DependencyProperty.Register("IconBrush", typeof(Brush), typeof(HoverFloatAdder), new PropertyMetadata(Brushes.White));

        [Category("Hover Float Adder")]
        public Brush IconHoverBrush
        {
            get { return (Brush)GetValue(IconHoverBrushProperty); }
            set { SetValue(IconHoverBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconHoverBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconHoverBrushProperty =
            DependencyProperty.Register("IconHoverBrush", typeof(Brush), typeof(HoverFloatAdder), new PropertyMetadata(Brushes.White));


        [Category("Hover Float Adder")]
        public new Brush Foreground
        {
            get { return (Brush)GetValue(ForegroundProperty); }
            set { SetValue(ForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Foreground.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.Register("Foreground", typeof(Brush), typeof(HoverFloatAdder), new PropertyMetadata(Brushes.White));

        #endregion       

        [Category("Hover Float Adder")]
        public float Value
        {
            get { return (float)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); OnValueChanged?.Invoke(this, EventArgs.Empty); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(float), typeof(HoverFloatAdder), new FrameworkPropertyMetadata((float)0, null, CoerceCurrentReading));

        private static object CoerceCurrentReading(DependencyObject depObj, object value)
        {
            HoverFloatAdder adder = (HoverFloatAdder)depObj;
            float v = (float)value;
            v = v > adder.MaxValue ? adder.MaxValue : v < adder.MinValue ? adder.MinValue : v;
            return v;
        }


        [Category("Hover Float Adder")]
        public float MinValue
        {
            get { return (float)GetValue(MinValueProperty); }
            set { SetValue(MinValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MinValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinValueProperty =
            DependencyProperty.Register("MinValue", typeof(float), typeof(HoverFloatAdder), new PropertyMetadata((float)0));

        [Category("Hover Float Adder")]
        public float MaxValue
        {
            get { return (float)GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MaxValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaxValueProperty =
            DependencyProperty.Register("MaxValue", typeof(float), typeof(HoverFloatAdder), new PropertyMetadata((float)255));

        private void DecreaseBtn_Click(object sender, RoutedEventArgs e)
        {
            Value--;
        }

        private void IncreaseBtn_Click(object sender, RoutedEventArgs e)
        {
            Value++;
        }

        public override void OnApplyTemplate()
        {
            HoverButton left = GetTemplateChild("DecreaseBtn") as HoverButton;
            HoverButton right = GetTemplateChild("IncreaseBtn") as HoverButton;
            HoverTextBox text = GetTemplateChild("ValueTxt") as HoverTextBox;

            if (left != null)
            {
                left.Click += DecreaseBtn_Click;
            }

            if (right != null)
            {
                right.Click += IncreaseBtn_Click;
            }

            if(text != null)
            {
                text.KeyUp += Text_KeyUp;
            }

            base.OnApplyTemplate();
        }

        private void Text_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                try
                {
                    float value = float.Parse(((HoverTextBox)sender).Text);
                    Value = value;
                }
                catch
                {
                    Value = MinValue;
                }
            }
        }
    }
}
