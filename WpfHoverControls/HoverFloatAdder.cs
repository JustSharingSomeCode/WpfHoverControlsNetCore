using System;
using System.Collections.Generic;
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


        #region CornerRadius

        public CornerRadius LeftButtonCornerRadius
        {
            get { return (CornerRadius)GetValue(LeftButtonCornerRadiusProperty); }
            set { SetValue(LeftButtonCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LeftButtonCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LeftButtonCornerRadiusProperty =
            DependencyProperty.Register("LeftButtonCornerRadius", typeof(CornerRadius), typeof(HoverFloatAdder), new PropertyMetadata(new CornerRadius(5, 0, 0, 5)));


        public CornerRadius RightButtonCornerRadius
        {
            get { return (CornerRadius)GetValue(RightButtonCornerRadiusProperty); }
            set { SetValue(RightButtonCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RightButtonCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RightButtonCornerRadiusProperty =
            DependencyProperty.Register("RightButtonCornerRadius", typeof(CornerRadius), typeof(HoverFloatAdder), new PropertyMetadata(new CornerRadius(0, 5, 5, 0)));


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


        public Brush ButtonBrush
        {
            get { return (Brush)GetValue(ButtonBrushProperty); }
            set { SetValue(ButtonBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonBrushProperty =
            DependencyProperty.Register("ButtonBrush", typeof(Brush), typeof(HoverFloatAdder), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(80, 80, 80))));


        public Brush ButtonHoverBrush
        {
            get { return (Brush)GetValue(ButtonHoverBrushProperty); }
            set { SetValue(ButtonHoverBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonHoverBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonHoverBrushProperty =
            DependencyProperty.Register("ButtonHoverBrush", typeof(Brush), typeof(HoverFloatAdder), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(100, 100, 100))));


        public Brush TextBoxBrush
        {
            get { return (Brush)GetValue(TextBoxBrushProperty); }
            set { SetValue(TextBoxBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextBoxBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextBoxBrushProperty =
            DependencyProperty.Register("TextBoxBrush", typeof(Brush), typeof(HoverFloatAdder), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(60, 60, 60))));


        public Brush TextBoxHoverBrush
        {
            get { return (Brush)GetValue(TextBoxHoverBrushProperty); }
            set { SetValue(TextBoxHoverBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextBoxHoverBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextBoxHoverBrushProperty =
            DependencyProperty.Register("TextBoxHoverBrush", typeof(Brush), typeof(HoverFloatAdder), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(70, 70, 70))));





        #endregion

    }
}
