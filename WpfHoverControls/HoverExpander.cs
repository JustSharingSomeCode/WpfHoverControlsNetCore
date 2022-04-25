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
    ///     <MyNamespace:HoverExpander/>
    ///
    /// </summary>
    public class HoverExpander : ContentControl
    {
        static HoverExpander()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HoverExpander), new FrameworkPropertyMetadata(typeof(HoverExpander)));
        }

        public event RoutedEventHandler Btn1_Click;
        public event RoutedEventHandler Btn2_Click;
        public event RoutedEventHandler Btn3_Click;

        public enum ButtonQuantity
        {
            None,
            One,
            Two,
            Three
        }

        public bool IsExpanded
        {
            get { return (bool)GetValue(IsExpandedProperty); }
            set { SetValue(IsExpandedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsExpanded.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsExpandedProperty =
            DependencyProperty.Register("IsExpanded", typeof(bool), typeof(HoverExpander), new PropertyMetadata(false));

        #region MultiButtons

        public ButtonQuantity ButtonsToDisplay
        {
            get { return (ButtonQuantity)GetValue(ButtonsToDisplayProperty); }
            set { SetValue(ButtonsToDisplayProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonsToDisplay.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonsToDisplayProperty =
            DependencyProperty.Register("ButtonsToDisplay", typeof(ButtonQuantity), typeof(HoverExpander), new PropertyMetadata(ButtonQuantity.None));



        public string Btn1Icon
        {
            get { return (string)GetValue(Btn1IconProperty); }
            set { SetValue(Btn1IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Btn1Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Btn1IconProperty =
            DependencyProperty.Register("Btn1Icon", typeof(string), typeof(HoverExpander), new PropertyMetadata("\uE104"));



        public string Btn2Icon
        {
            get { return (string)GetValue(Btn2IconProperty); }
            set { SetValue(Btn2IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Btn2Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Btn2IconProperty =
            DependencyProperty.Register("Btn2Icon", typeof(string), typeof(HoverExpander), new PropertyMetadata("\uE71E"));



        public string Btn3Icon
        {
            get { return (string)GetValue(Btn3IconProperty); }
            set { SetValue(Btn3IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Btn3Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Btn3IconProperty =
            DependencyProperty.Register("Btn3Icon", typeof(string), typeof(HoverExpander), new PropertyMetadata("\uE107"));



        public Brush ButtonsBackground
        {
            get { return (Brush)GetValue(ButtonsBackgroundProperty); }
            set { SetValue(ButtonsBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonsBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonsBackgroundProperty =
            DependencyProperty.Register("ButtonsBackground", typeof(Brush), typeof(HoverExpander), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(45, 90, 125))));



        public Brush ButtonsBackgroundHover
        {
            get { return (Brush)GetValue(ButtonsBackgroundHoverProperty); }
            set { SetValue(ButtonsBackgroundHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonsBackgroundHover.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonsBackgroundHoverProperty =
            DependencyProperty.Register("ButtonsBackgroundHover", typeof(Brush), typeof(HoverExpander), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(70, 150, 200))));



        public double ButtonsSize
        {
            get { return (double)GetValue(ButtonsSizeProperty); }
            set { SetValue(ButtonsSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonsSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonsSizeProperty =
            DependencyProperty.Register("ButtonsSize", typeof(double), typeof(HoverExpander), new PropertyMetadata((double)30));



        public double ButtonsIconSize
        {
            get { return (double)GetValue(ButtonsIconSizeProperty); }
            set { SetValue(ButtonsIconSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonsIconSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonsIconSizeProperty =
            DependencyProperty.Register("ButtonsIconSize", typeof(double), typeof(HoverExpander), new PropertyMetadata((double)15));



        public double ButtonsRightMargin
        {
            get { return (double)GetValue(ButtonsRightMarginProperty); }
            set { SetValue(ButtonsRightMarginProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonsSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonsRightMarginProperty =
            DependencyProperty.Register("ButtonsRightMargin", typeof(double), typeof(HoverExpander), new PropertyMetadata((double)25));



        #endregion

        #region Expander


        
        public string UpIcon
        {
            get { return (string)GetValue(UpIconProperty); }
            set { SetValue(UpIconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UpIcon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UpIconProperty =
            DependencyProperty.Register("UpIcon", typeof(string), typeof(HoverExpander), new PropertyMetadata("\uE96D"));



        public string DownIcon
        {
            get { return (string)GetValue(DownIconProperty); }
            set { SetValue(DownIconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DownIcon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DownIconProperty =
            DependencyProperty.Register("DownIcon", typeof(string), typeof(HoverExpander), new PropertyMetadata("\uE96E"));
        


        #endregion



        public new Brush Background
        {
            get { return (Brush)GetValue(BackgroundProperty); }
            set { SetValue(BackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Background.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.Register("Background", typeof(Brush), typeof(HoverExpander), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(45, 90, 125))));



        public new Brush Foreground
        {
            get { return (Brush)GetValue(ForegroundProperty); }
            set { SetValue(ForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Foreground.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.Register("Foreground", typeof(Brush), typeof(HoverExpander), new PropertyMetadata(new SolidColorBrush(Colors.White)));


        public CornerRadius LeftButtonCornerRadius
        {
            get { return (CornerRadius)GetValue(LeftButtonCornerRadiusProperty); }
            set { SetValue(LeftButtonCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LeftButtonCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LeftButtonCornerRadiusProperty =
            DependencyProperty.Register("LeftButtonCornerRadius", typeof(CornerRadius), typeof(HoverExpander), new PropertyMetadata(new CornerRadius(5, 0, 0, 5)));


        public CornerRadius RightButtonCornerRadius
        {
            get { return (CornerRadius)GetValue(RightButtonCornerRadiusProperty); }
            set { SetValue(RightButtonCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RightButtonCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RightButtonCornerRadiusProperty =
            DependencyProperty.Register("RightButtonCornerRadius", typeof(CornerRadius), typeof(HoverExpander), new PropertyMetadata(new CornerRadius(0, 5, 5, 0)));


        public CornerRadius SingleButtonCornerRadius
        {
            get { return (CornerRadius)GetValue(SingleButtonCornerRadiusProperty); }
            set { SetValue(SingleButtonCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SingleButtonCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SingleButtonCornerRadiusProperty =
            DependencyProperty.Register("SingleButtonCornerRadius", typeof(CornerRadius), typeof(HoverExpander), new PropertyMetadata(new CornerRadius(5)));



        public bool ShowExpandIcon
        {
            get { return (bool)GetValue(ShowExpandIconProperty); }
            set { SetValue(ShowExpandIconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ShowExpandIcon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowExpandIconProperty =
            DependencyProperty.Register("ShowExpandIcon", typeof(bool), typeof(HoverExpander), new PropertyMetadata(true));



        public new FontFamily FontFamily
        {
            get { return (FontFamily)GetValue(FontFamilyProperty); }
            set { SetValue(FontFamilyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FontFamily.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty FontFamilyProperty =
            DependencyProperty.Register("FontFamily", typeof(FontFamily), typeof(HoverExpander), new PropertyMetadata(new FontFamily("Segoe UI")));



        public new double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FontSize.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty FontSizeProperty =
            DependencyProperty.Register("FontSize", typeof(double), typeof(HoverExpander), new PropertyMetadata((double)12));




        public override void OnApplyTemplate()
        {
            HoverButton btn = GetTemplateChild("ExpanderBtn") as HoverButton;
            HoverButton btn1 = GetTemplateChild("Btn1") as HoverButton;
            HoverButton btn2 = GetTemplateChild("Btn2") as HoverButton;
            HoverButton btn3 = GetTemplateChild("Btn3") as HoverButton;

            btn.Click += ExpanderBtn_Click;

            btn1.Click += Btn1_Click1;
            btn2.Click += Btn2_Click1;
            btn3.Click += Btn3_Click1;

            base.OnApplyTemplate();
        }

        private void Btn3_Click1(object sender, RoutedEventArgs e)
        {
            Btn3_Click?.Invoke(sender, e);
        }

        private void Btn2_Click1(object sender, RoutedEventArgs e)
        {
            Btn2_Click?.Invoke(sender, e);
        }

        private void Btn1_Click1(object sender, RoutedEventArgs e)
        {
            Btn1_Click?.Invoke(sender, e);
        }

        private void ExpanderBtn_Click(object sender, RoutedEventArgs e)
        {
            IsExpanded = !IsExpanded;
        }
    }
}
