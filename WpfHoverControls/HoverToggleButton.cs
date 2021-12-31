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
    ///     <MyNamespace:HoverToggleButton/>
    ///
    /// </summary>
    public class HoverToggleButton : Control
    {
        static HoverToggleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HoverToggleButton), new FrameworkPropertyMetadata(typeof(HoverToggleButton)));
        }

        [Category("Hover Toggle Button")]
        public Brush EnabledBrushColor
        {
            get { return (Brush)GetValue(EnabledBrushColorProperty); }
            set { SetValue(EnabledBrushColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EnabledBrushColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EnabledBrushColorProperty =
            DependencyProperty.Register("EnabledBrushColor", typeof(Brush), typeof(HoverToggleButton), new PropertyMetadata(new SolidColorBrush(Colors.Black)));

        [Category("Hover Toggle Button")]
        public Brush DisabledBrushColor
        {
            get { return (Brush)GetValue(DisabledBrushColorProperty); }
            set { SetValue(DisabledBrushColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DisabledBrushColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DisabledBrushColorProperty =
            DependencyProperty.Register("DisabledBrushColor", typeof(Brush), typeof(HoverToggleButton), new PropertyMetadata(new SolidColorBrush(Colors.Gray)));

        [Category("Hover Toggle Button")]
        public new Brush Foreground
        {
            get { return (Brush)GetValue(ForegroundProperty); }
            set { SetValue(ForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Foreground.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.Register("Foreground", typeof(Brush), typeof(HoverToggleButton), new PropertyMetadata(new SolidColorBrush(Colors.White)));

        [Category("Hover Toggle Button")]
        public bool Value
        {
            get { return (bool)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(bool), typeof(HoverToggleButton), new PropertyMetadata(true));

        private void OnBtn_Click(object sender, RoutedEventArgs e)
        {
            Value = true;
        }

        private void OffBtn_Click(object sender, RoutedEventArgs e)
        {
            Value = false;
        }

        public override void OnApplyTemplate()
        {
            HoverButton on = GetTemplateChild("OnBtn") as HoverButton;
            HoverButton off = GetTemplateChild("OffBtn") as HoverButton;

            on.Click += OnBtn_Click;
            off.Click += OffBtn_Click;

            base.OnApplyTemplate();
        }
    }
}
