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
    ///     <MyNamespace:HoverComboBox/>
    ///
    /// </summary>
    public class HoverComboBox : ComboBox
    {
        static HoverComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HoverComboBox), new FrameworkPropertyMetadata(typeof(HoverComboBox)));
        }


        [Category("Hover ComboBox")]
        public new Brush Background
        {
            get { return (Brush)GetValue(BackgroundProperty); }
            set { SetValue(BackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Background.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.Register("Background", typeof(Brush), typeof(HoverComboBox), new PropertyMetadata(new SolidColorBrush(Colors.Black)));

        [Category("Hover ComboBox")]
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(HoverComboBox), new PropertyMetadata(new CornerRadius(5)));

        [Category("Hover ComboBox")]
        public new Brush Foreground
        {
            get { return (Brush)GetValue(ForegroundProperty); }
            set { SetValue(ForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Foreground.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.Register("Foreground", typeof(Brush), typeof(HoverComboBox), new PropertyMetadata(new SolidColorBrush(Colors.White)));

        [Category("Hover ComboBox")]
        public Brush ItemForegroundHover
        {
            get { return (Brush)GetValue(ItemForegroundHoverProperty); }
            set { SetValue(ItemForegroundHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemForegroundHover.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemForegroundHoverProperty =
            DependencyProperty.Register("ItemForegroundHover", typeof(Brush), typeof(HoverComboBox), new PropertyMetadata(new SolidColorBrush(Colors.White)));

        [Category("Hover ComboBox")]
        public Brush ItemBackgroundHover
        {
            get { return (Brush)GetValue(ItemBackgroundHoverProperty); }
            set { SetValue(ItemBackgroundHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemBackgroundHover.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemBackgroundHoverProperty =
            DependencyProperty.Register("ItemBackgroundHover", typeof(Brush), typeof(HoverComboBox), new PropertyMetadata(new SolidColorBrush(Colors.DarkGray)));

        [Category("Hover ComboBox")]
        public new Brush BorderBrush
        {
            get { return (Brush)GetValue(BorderBrushProperty); }
            set { SetValue(BorderBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BorderBrush.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty BorderBrushProperty =
            DependencyProperty.Register("BorderBrush", typeof(Brush), typeof(HoverComboBox), new PropertyMetadata(new SolidColorBrush(Colors.DarkGray)));

        [Category("Hover ComboBox")]
        public new FontFamily FontFamily
        {
            get { return (FontFamily)GetValue(FontFamilyProperty); }
            set { SetValue(FontFamilyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FontFamily.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty FontFamilyProperty =
            DependencyProperty.Register("FontFamily", typeof(FontFamily), typeof(HoverComboBox), new PropertyMetadata(new FontFamily("Segoe UI")));

        [Category("Hover ComboBox")]
        public new double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FontSize.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty FontSizeProperty =
            DependencyProperty.Register("FontSize", typeof(double), typeof(HoverComboBox), new PropertyMetadata((double)12));





    }
}
