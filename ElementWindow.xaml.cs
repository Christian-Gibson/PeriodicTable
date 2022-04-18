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

namespace PeriodicTableV1
{
    /// <summary>
    /// Interaction logic for ElementWindow.xaml
    /// </summary>
    public partial class ElementWindow : Window
    {
        public ElementWindow()
        {
            InitializeComponent();
        }


        #region Element Buttons

        private void btn_Hydrogen_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "1. Hydrogen \n Weight: 1.008 u \n Electronegativity: 2.20 \n Melting Point: 14.01 K \n Boiling Point: 20.28 K \n Discovered in 1766.";

        }

        private void btn_Lithium_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "3. Lithium \n Weight: 6.94 u \n Electronegativity: 0.98 \n Melting Point: 453.69 K \n Boiling Point: 1615 K \n Discovered in 1817.";

        }

        private void btn_Sodium_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "11. Sodium \n Weight: 22.990 u\n Electronegativity: 0.93 \n Melting Point: 370.87 K \n Boiling Point: 1156 K \n Discovered in 1807.";

        }



        private void btn_Potassium_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "19. Potassium \n Weight: 39.0983 u \n Electronegativity: 0.82 \n Melting Point: 336.53 K \n Boiling Point: 1032 K \n Discovered in 1807.";


        }

        private void btn_Rubidium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "37. Rubidium \n Weight: 85.4678 u \n Electronegativity: 0.82 \n Melting Point: 312.46 K \n Boiling Point: 961 K \n Discovered in 1861";

        }

        private void btn_Caesium_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "55. Caesium \n Weight: 132.91 u \n Electronegativity: 0.79 \n Melting Point: 301.59 K \n Boiling Point: 944 K \n Discovered in 1860";

        }

        private void btn_Francium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "87. Francium \n Weight: (223)  \n  Electronegativity: 0.7 \n Melting Point: Unknown \n Boiling Point: Unknown \n Discovered in 1939";

        }

        private void btn_Beryllium_Click(object sender, RoutedEventArgs e)
        {


            textbox1.Text = "4. Beryllium \n Weight: 9.0122 u\n Electronegativity: 1.57\n Melting Point: 1560 K\n Boiling Point: 2743 K\n Discovered in 1797";

        }

        private void btn_Magnesium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "12. Magnesium \n Weight: 24.305 u \n Electronegativity: 1.31\n Melting Point: 923 K     \n Boiling Point: 1363 K \n Discovered in 1755 ";
        }

        private void btn_Calcium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "20. Calcium   \n Weight: 40.078 u    \n Electronegativity: 1.0     \n Melting Point: 1115 K    \n Boiling Point: 1757 K      \n Discovered in 1808";
        }

        private void btn_Strontium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "38. Stronium \n Weight: 87.62 u \n Electronegativity: 0.95\n Melting Point: 1050 K\n Boiling Point: 1655 K\n Discovered in 1790";
        }

        private void btn_Barium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "56. Barium \n Weight: 137.33 u \n Electronegativity: 0.89\n Melting Point: 1000 K\n Boiling Point: 2143 K\n Discovered in 1808";
        }

        private void btn_Radium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "88. Radium  \n Weight: (226) \n Electronegativity: 0.9\n Melting Point: 973 K \n Boiling Point: 2010 K \n Discovered in 1898";
        }

        private void btn_Scandium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "21. Scandium  \n Weight: 44.956 u  \n Electronegativity: 1.36 \n Melting Point: 1814 K\n Boiling Point: 3103 K\n Discovered in 1879";
        }

        private void btn_Yttrium_Click(object sender, RoutedEventArgs e)
        {


            textbox1.Text = "39. Yttrium\n Weight: 88.906 u \n Electronegativity: 1.22 \n Melting Point: 1799 K\n Boiling Point: 3618 K \n Discovered in 1794";
        }

        private void btn_Lanthanum_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "57. Lanthanum \n Weight: 138.91 u  \n Electronegativity: 1.10\n Melting Point: 1193 K\n Boiling Point: 3737 K\n Discovered in 1839";

        }

        private void btn_Actinium_Click(object sender, RoutedEventArgs e)
        {


            textbox1.Text = "89. Actinium  \n Weight: (227) \n Electronegativity: 1.1\n Melting Point: 1323 K\n Boiling Point: 3473 K\n Discovered in 1899";
        }

        private void btn_Titanium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "22. Titanium \n Weight: 47.867 u \n Electronegativity: 1.54\n Melting Point: 1941 K\n Boiling Point: 3560 K\n Discovered in 1791";
        }

        private void btn_Zirconium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "40. Zirconium \n Weight: 91.224 u \n Electronegativity: 1.33\n Melting Point: 2128 K\n Boiling Point: 4682 K\n Discovered in 1789";
        }

        private void btn_Hafnium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "72. Hafnium \n Weight: 178.49 u\n Electronegativity: 1.3\n Melting Point: 2506 K\n Boiling Point: 4876 K \n Discovered in 1923";
        }

        private void btn_Rutherfordium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "104. Rutherfordium \n Weight: (267) \n Electronegativity: Unknown\n Melting Point: Unknown\n Boiling Point: Unknown\n Discovered in 1964";
        }

        private void btn_Vanadium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "23. Vanadium\n Weight: 50.942 u \n Electronegativity: 1.63 \n Melting Point: 2183 K\n Boiling Point: 3680 K\n Discovered in 1801";
        }

        private void btn_Niobium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "41. Niobium \n Weight: 92.906 u\n Electronegativity: 1.6\n Melting Point: 2750 K\n Boiling Point: 5017 K\n Discovered in 1801";
        }

        private void btn_Tantalum_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "73. Tantalum \n Weight: 180.95 u \n Electronegativity: 1.5\n Melting Point: 3290 K\n Boiling Point: 5731 K\n Discovered in 1802";
        }

        private void btn_Dubnium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "105. Dubnium \n Weight: (268) \n Electronegativity: Unknown\n Melting Point: Unknown\n Boiling Point: Unknown\n Discovered in 1967";
        }

        private void btn_Chromium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "24. Chromium \n Weight: 51.996 u \n Electronegativity: 1.66\n Melting Point: 2180 K\n Boiling Point: 2944 K\n Discovered in 1797";
        }

        private void btn_Molybdenum_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "42. Molybdenum \n Weight: 95.95 u \n Electronegativity: 2.16\n Melting Point: 2896 K\n Boiling Point: 4912 K\n Discovered in 1781";
        }

        private void btn_Tungsten_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "74. Tungsten \n Weight: 183.84 u\n Electronegativity: 2.36\n Melting Point: 3695 K\n Boiling Point: 5828 K\n Discovered in 1783";
        }

        private void btn_Seaborgium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "106. Seaborgium \n Weight: (269) \n Electronegativity: Unknown\n Melting Point: Unknown\n Boiling Point: Unknown\n Discovered in 1974";
        }

        private void btn_Manganese_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "25. Manganese\n Weight: 54.938 u \n Electronegativity: 1.55 \n Melting Point: 1519 K\n Boiling Point: 2334 K\n Discovered in 1774";
        }

        private void btn_Technetium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "43. Technetium \n Weight: (98) \n Electronegativity: 1.9\n Melting Point: 2430 K\n Boiling Point: 4538 K\n Discovered in 1937";
        }

        private void btn_Rhenium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "75. Rhenium \n Weight: 186.21 u \n Electronegativity: 1.9\n Melting Point: 3459 K\n Boiling Point: 5869 K\n Discovered in 1925";
        }

        private void btn_Bohrium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "107. Bohrium \n Weight: (270)\n Electronegativity: Unknown\n Melting Point: Unknown\n Boiling Point: Unknown \n Discovered in 1981";
        }

        private void btn_Iron_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "26. Iron \n Weight: 55.845 u\n Electronegativity: 1.83\n Melting Point: 1811 K\n Boiling Point: 3134 K\n Discovered in 3500 B.C.";
        }

        private void btn_Ruthenium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "44. Ruthenium\n Weight: 101.07 u \n Electronegativity: 2.2\n Melting Point: 2607 K\n Boiling Point: 4423 K\n Discovered in 1844";
        }

        private void btn_Osmium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "76. Osmium \n Weight: 190.23 u \n Electronegativity: 2.2\n Melting Point: 3306 K\n Boiling Point: 5285 K\n Discovered in 1803";
        }

        private void btn_Hassium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "108. Hassium \n Weight: (277) \n Electronegativity: Unknown\n Melting Point: Unknown\n Boiling Point: Unknown\n Discovered in 1984";
        }

        private void btn_Cobalt_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "27. Cobalt \n Weight: 58.933 u\n Electronegativity: 1.88\n Melting Point: 1768 K\n Boiling Point: 3200 K\n Discovered in 1735";
        }

        private void btn_Rhodium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "45. Rhodium\n Weight: 102.91 u \n Electronegativity: 2.28\n Melting Point: 2237 K\n Boiling Point: 3968 K\n Discovered in 1803";
        }

        private void btn_Iridium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "77. Iridium \n Weight: 192.22 u\n Electronegativity: 2.20\n Melting Point: 2739 K\n Boiling Point: 4701 K\n Discovered in 1803";
        }

        private void btn_Meitnerium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "109. Meitnerium \n Weight: (278)\n Electronegativity: Unknown\n Melting Point: Unknown\n Boiling Point: Unknown\n Discovered in 1982  ";
        }

        private void btn_Nickel_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "28. Nickel \n Weight: 58.693 u \n Electronegativity: 1.91\n Melting Point: 1728 K\n Boiling Point: 3186 K\n Discovered in 1751";
        }

        private void btn_Palladium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "46. Palladium \n Weight: 106.42 u \n Electronegativity: 2.20\n Melting Point: 1828.05 K\n Boiling Point: 3236 K\n Discovered in 1803 ";

        }

        private void btn_Platinum_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "78. Platinum \n Weight: 195.08 u \n Electronegativity: 2.28\n Melting Point: 2041.4 K\n Boiling Point: 4098 K\n Discovered in 1735";
        }

        private void btn_Darmstadtium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "110. Darmstadtium\n Weight: (281) \n Electronegativity: Unknown\n Melting Point: Unknown\n Boiling Point: Unknown \n Discovered in 1994 ";
        }

        private void btn_Copper_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "29. Copper \n Weight: 63.546 u \n Electronegativity: 1.90\n Melting Point: 1357.77 K\n Boiling Point: 2835 K\n Discovered in 9000 B.C.";
        }

        private void btn_Silver_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "47. Silver \n Weight: 107.87 u \n Electronegativity: 1.93\n Melting Point: 1234.93 K\n Boiling Point: 2435 K\n Discovered in 4000 B.C.";
        }

        private void btn_Gold_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "79. Gold  \n Weight: 196.97 u \n Electronegativity: 2.54 \n Melting Point: 1337.33 K\n Boiling Point: 3129 K \n Discovered in 2600 B.C.";
        }

        private void btn_Roentgenium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "111. Roentgenium \n Weight: (282) \n Electronegativity: Unknown\n Melting Point: Unknown\n Boiling Point: Unknown\n Discovered in 1994";
        }

        private void btn_Zinc_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "30. Zinc \n Weight: 65.38 u  \n Electronegativity: 1.65\n Melting Point: 692.68 K\n Boiling Point: 1180 K  \n Discovered in 1500";
        }

        private void btn_Cadmium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "48. Cadmium \n Weight: 112.41 u \n Electronegativity: 1.69\n Melting Point: 594.22 K\n Boiling Point: 1040 K\n Discovered in 1817";
        }

        private void btn_Mercury_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "80. Mercury \n Weight: 200.59 u \n Electronegativity: 2.0\n Melting Point: 234.32 K\n Boiling Point: 629.88 K\n Discovered in 1500 B.C.";
        }

        private void btn_Copernicium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "112. Copernicium \n Weight: (285) \n Electronegativity: Unknown\n Melting Point: Unknown\n Boiling Point: Unknown\n Discovered in 1996";
        }

        private void btn_Boron_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "5. Boron \n Weight: 10.81 u \n Electronegativity: 2.04\n Melting Point: 2348 K\n Boiling Point: 4273 K\n Discovered in 1808";
        }

        private void btn_Aluminium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "13. Aluminium \n Weight: 26.982 u \n Electronegativity: 1.61\n Melting Point: 933.47 K\n Boiling Point: 2792 K\n Discovered in 1825 ";
        }

        private void btn_Gallium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "31. Gallium   \n Weight: 69.723 u \n Electronegativity: 1.81\n Melting Point: 302.91 K\n Boiling Point: 2477 K\n Discovered in 1875";
        }

        private void btn_Indium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "49. Indium \n Weight: 114.82 u \n Electronegativity: 1.78 \n Melting Point: 429.75 K\n Boiling Point: 2345 K \n Discovered in 1863";
        }

        private void btn_Thallium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "81. Thallium \n Weight: 204.38 u\n Electronegativity: 1.62\n Melting Point: 577 K\n Boiling Point: 1746 K\n Discovered in 1861";
        }

        private void btn_Nihonium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "113. Nihonium \n Weight: (286)\n Electronegativity: Unknown\n Melting Point: Unknown\n Boiling Point: Unknown\n Discovered in 2004     ";
        }

        private void btn_Carbon_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "6. Carbon \n Weight: 12.011 u \n Electronegativity: 2.55\n Melting Point: 3823 K\n Boiling Point: 4300 K\n Discovered in 3750 B.C.";
        }

        private void btn_Silicon_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "14. Silicon \n Weight: 28.085 u\n Electronegativity: 1.90\n Melting Point: 1687 K\n Boiling Point: 3175 K\n Discovered in 1824";
        }

        private void btn_Germanium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "32. Germanium \n Weight: 72.630 u \n Electronegativity: 2.01\n Melting Point: 1211.4 K\n Boiling Point: 3093 K\n Discovered in 1886";
        }

        private void btn_Tin_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "50. Tin\n Weight: 118.71 u\n Electronegativity: 1.96\n Melting Point: 505.08 K\n Boiling Point: 2875 K\n Discovered in 3000 B.C.";
        }

        private void btn_Lead_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "82. Lead \n Weight: 207.2 u\n Electronegativity: 2.33\n Melting Point: 600.61 K\n Boiling Point: 2022 K\n Discovered in 4000 B.C.";
        }

        private void btn_Flerovium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "114. Flerovium \n Weight: (289) \n Electronegativity: Unknown\n Melting Point: Unknown\n Boiling Point: Unknown\n Discovered in 1998";
        }

        private void btn_Nitrogen_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "7. Nitrogen\n Weight: 14.007 u \n Electronegativity: 3.04\n Melting Point: 63.05 K\n Boiling Point: 77.36 K\n Discovered in 1772";
        }

        private void btn_Phosphorous_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "15. Phosphorous \n Weight: 30.974 u \n Electronegativity: 2.19\n Melting Point: 317.3 K\n Boiling Point: 553.6 K\n Discovered in 1669";
        }

        private void btn_Arsenic_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "33. Arsenic \n Weight: 74.922 u \n Electronegativity: 2.18\n Melting Point: 1090 K\n Boiling Point: 887 K \n Discovered in 1250 ";
        }

        private void btn_Antimony_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "51. Antimony \n Weight: 121.76 u \n Electronegativity: 2.05\n Melting Point: 903.78 K\n Boiling Point: 1860 K \n Discovered in 3000 B.C.";
        }

        private void btn_Bismuth_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "83. Bismuth \n Weight: 208.98 u \n Electronegativity: 2.02\n Melting Point: 544.4 K\n Boiling Point: 1837 K\n Discovered in 1400";
        }

        private void btn_Moscovium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "115. Moscovium  \n Weight: (290) \n Electronegativity: Unknown\n Melting Point: Unknown\n Boiling Point: Unknown \n Discovered in 2004 ";
        }

        private void btn_Oxygen_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "8. Oxygen \n Weight: 15.999 u  \n Electronegativity: 3.44\n Melting Point: 54.8 K\n Boiling Point: 90.2 K\n Discovered in 1774";
        }

        private void btn_Sulfur_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "16. Sulfur \n Weight: 32.06 u \n Electronegativity: 2.58 \n Melting Point: 388.36 K\n Boiling Point: 717.87 K\n Discovered in 500 B.C.";
        }

        private void btn_Selenium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "34. Selenium \n Weight: 78.971 u \n Electronegativity: 2.55\n Melting Point: 494 K\n Boiling Point: 958 K\n Discovered in 1817";
        }

        private void btn_Tellurium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "52. Tellurium \n Weight: 127.60 u \n Electronegativity: 2.1\n Melting Point: 722.66 K\n Boiling Point: 1261 K\n Discovered in 1783";
        }

        private void btn_Polonium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "84. Polonium \n Weight: (209)  \n Electronegativity: 2.0\n Melting Point: 528 K \n Boiling Point: 1235 K \n Discovered in 1898";
        }

        private void btn_Livermorium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "116. Livermorium \n Weight: (293) \n Electronegativity: Unknown\n Melting Point: Unknown\n Boiling Point: Unknown \n Discovered in 2000     ";
        }

        private void btn_Fluorine_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "9. Fluorine \n Weight: 18.998 u \n Electronegativity: 3.98 \n Melting Point: 53.3 K\n Boiling Point: 85.03 K\n Discovered in 1886";
        }

        private void btn_Chlorine_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "17. Chlorine \n Weight: 35.45 u \n Electronegativity: 3.16\n Melting Point: 171.6 K\n Boiling Point: 239.11 K\n Discovered in 1774";
        }

        private void btn_Bromine_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "35. Bromine\n Weight: 79.904 u \n Electronegativity: 2.96\n Melting Point: 265.8 K\n Boiling Point: 332 K\n Discovered in 1826";
        }

        private void btn_Iodine_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "53. Iodine \n Weight: 126.90 u \n Electronegativity: 2.66\n Melting Point: 386.85 K\n Boiling Point: 457.4 K\n Discovered in 1811";
        }

        private void btn_Astatine_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "85. Astatine \n Weight: (210) \n Electronegativity: 2.2 \n Melting Point: 577 K \n Boiling Point: Unknown \n Discovered in 1940";
        }

        private void btn_Tennessine_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "117. Tennessine \n Weight: (294) \n Electronegativity: Unknown \n Melting Point: Unknown\n Boiling Point: Unknown\n Discovered in 2010";
        }

        private void btn_Helium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "2. Helium  \n Weight: 4.0026 u \n Electronegativity: Unknown\n Melting Point: Unknown\n Boiling Point: 4.22 K\n Discovered in 1895";
        }

        private void btn_Neon_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "10. Neon \n Weight: 20.180 u \n Electronegativity: Unknown\n Melting Point: 24.56 K\n Boiling Point: 27.07 K \n Discovered in 1898 ";
        }

        private void btn_Argon_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "18. Argon \n Weight: 39.948 u \n Electronegativity: Unknown\n Melting Point: 83.8 K\n Boiling Point: 87.3 K\n Discovered in 1894";
        }

        private void btn_Krypton_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "36. Krypton \n Weight: 83.798 u \n Electronegativity: 3.0\n Melting Point: 115.79 K\n Boiling Point: 119.93 K \n Discovered in 1898";
        }

        private void btn_Xenon_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "54. Xenon\n Weight: 131.29 u\n Electronegativity: 2.6\n Melting Point: 161.3 K\n Boiling Point: 165.1 K\n Discovered in 1898";
        }

        private void btn_Radon_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "86. Radon \n Weight: (222) \n Electronegativity: Unknown \n Melting Point: 202 K\n Boiling Point: 211.3 K \n Discovered in 1900";
        }

        private void btn_Oganesson_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "118. Oganesson \n Weight: Unknown\n Electronegativity: Unknown\n Melting Point: Unknown\n Boiling Point: Unknown\n Discovered in 2006";
        }

        private void btn_LanthanumS_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "57. Lanthanum\n Weight: 138.91 u \n Electronegativity: 1.10\n Melting Point: 1193 K\n Boiling Point: 3737 K\n Discovered in 1839";
        }

        private void btn_ActiniumS_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "89. Actinium \n Weight: (227) \n Electronegativity: 1.1\n Melting Point: 1323 K\n Boiling Point: 3473 K\n Discovered in 1899";
        }

        private void btn_Cerium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "58. Cerium\n Weight: 140.12 u \n Electronegativity: 1.12\n Melting Point: 1071 K\n Boiling Point: 3633 K\n Discovered in 1803";
        }

        private void btn_Thorium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "90. Thorium\n Weight: 232.04 u\n Electronegativity: 1.3\n Melting Point: 2023 K\n Boiling Point: 5093 K\n Discovered in 1829";
        }

        private void btn_Praseodymium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "59. Praseodymium \n Weight: 140.91 u \n Electronegativity: 1.13\n Melting Point: 1204 K\n Boiling Point: 3563 K\n Discovered in 1885";
        }

        private void btn_Protactiniuim_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "91. Protactinium \n Weight: 231.04 u\n Electronegativity: 1.5\n Melting Point: 1845 K\n Boiling Point: 4273 K\n Discovered in 1913";
        }

        private void btn_Neodymium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "60. Neodymium \n Weight: 144.24 u \n Electronegativity: 1.14\n Melting Point: 1294 K\n Boiling Point: 3373 K\n Discovered in 1885";
        }

        private void btn_Uranium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "92. Uranium \n Weight: 238.03 u \n Electronegativity: 1.38\n Melting Point: 1408 K\n Boiling Point: 4200 K\n Discovered in 1789";
        }

        private void btn_Promethium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "61. Promethium \n Weight: (145) \n Electronegativity: Unknown\n Melting Point: 1373 K\n Boiling Point: 3273 K \n Discovered in 1945";
        }

        private void btn_Neptunium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "93. Neptunium \n Weight: (237) \n Electronegativity: 1.36\n Melting Point: 917 K\n Boiling Point: 4273 K \n Discovered in 1940";
        }

        private void btn_Samarium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "62. Samarium \n Weight: 150.36 u \n Electronegativity: 1.17\n Melting Point: 1345 K\n Boiling Point: 2076 K \n Discovered in 1879";
        }

        private void btn_Plutonium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "94. Plutonium \n Weight: (244) \n Electronegativity: 1.28\n Melting Point: 913 K \n Boiling Point: 3503 K \n Discovered in 1940";
        }

        private void btn_Europium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "63. Europium\n Weight: 151.96 u \n Electronegativity: Unknown\n Melting Point: 1095 K\n Boiling Point: 1800 K \n Discovered in 1901";
        }

        private void btn_Americium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "95. Americium\n Weight: (243) \n Electronegativity: 1.3\n Melting Point: 1449 K\n Boiling Point: 2284 K \n Discovered in 1944";
        }

        private void btn_Gadolinium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "64. Gadolinium\n Weight: 157.25 u  \n Electronegativity: 1.20\n Melting Point: 1586 K\n Boiling Point: 3523 K\n Discovered in 1880";
        }

        private void btn_Curium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "96. Curium \n Weight: (247) \n Electronegativity: 1.3\n Melting Point: 1618 K\n Boiling Point: 3383 K \n Discovered in 1944";
        }

        private void btn_Terbium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "65. Terbium \n Weight: 158.93 u \n Electronegativity: Unknown\n Melting Point: 1629 K\n Boiling Point: 3503 K\n Discovered in 1843";
        }

        private void btn_Berkelium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "97. Berkelium \n Weight: (247) \n Electronegativity: 1.3\n Melting Point: 1323 K\n Boiling Point: Unknown \n Discovered in 1949";
        }

        private void btn_Dysprosium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "66. Dysprosium \n Weight: 162.50 u \n Electronegativity: 1.22 \n Melting Point: 1685 K\n Boiling Point: 2840 K \n Discovered in 1886";
        }

        private void btn_Californium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "98. Californium \n Weight: (251) \n Electronegativity: 1.3\n Melting Point: 1173 K\n Boiling Point: Unknown\n Discovered in 1950";
        }

        private void btn_Holmium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "67. Holmium \n Weight: 164.93 u \n Electronegativity: 1.23\n Melting Point: 1747 K\n Boiling Point: 2973 K\n Discovered in 1878";
        }

        private void btn_Einsteinium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "99. Einsteinium\n Weight: (252) \n Electronegativity: 1.3\n Melting Point: 1133 K \n Boiling Point: Unknown \n Discovered in 1952";
        }

        private void btn_Erbium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "68. Erbium \n Weight: 167.26 u \n Electronegativity: 1.24\n Melting Point: 1770 K \n Boiling Point: 3141 K\n Discovered in 1842";
        }

        private void btn_Fermium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "100. Fermium \n Weight: (257) \n Electronegativity: 1.3\n Melting Point: 1800 K\n Boiling Point: Unknown\n Discovered in 1952";
        }

        private void btn_Thulium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "69. Thulium  \n Weight: 168.93 u  \n Electronegativity: 1.25\n Melting Point: 1818 K\n Boiling Point: 2223 K\n Discovered in 1879";
        }

        private void btn_Mendelevium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "101. Medelevium \n Weight: (258) \n Electronegativity: 1.3 \n Melting Point: 1100 K\n Boiling Point: Unknown \n Discovered in 1955";
        }

        private void btn_Ytterbium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "70. Ytterbium \n Weight: 173.05 u \n Electronegativity: Unknown\n Melting Point: 1092 K\n Boiling Point: 1469 K \n Discovered in 1878";
        }

        private void btn_Nobelium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "102. Nobelium \n Weight: (259) \n Electronegativity: 1.3 \n Melting Point: 1100 K\n Boiling Point: Unknown     \n Discovered in 1958";
        }

        private void btn_Lutetium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "71. Lutetium\n Weight: 174.97 u \n Electronegativity: 1.27\n Melting Point: 1936 K\n Boiling Point: 3675 K\n Discovered in 1907";
        }

        private void btn_Lawrencium_Click(object sender, RoutedEventArgs e)
        {

            textbox1.Text = "103. Lawrencium \n Weight: (266)  \n Electronegativity: Unknown\n Melting Point: 1900 K\n Boiling Point: Unknown\n Discovered in 1961";
        }


        #endregion

        private void About_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Programmed and designed by Christian A. Gibson - 2022 \nSources: Wikipedia.org", "About", MessageBoxButton.OK, MessageBoxImage.Question);

        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            Close();


        }
    }
}
