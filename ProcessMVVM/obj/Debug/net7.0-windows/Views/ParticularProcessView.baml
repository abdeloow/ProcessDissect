   M S B A M L   `   `   `  ����F  BProcessMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProcessMVVM.ViewsProcessMVVM.Views  5      -    'ProcessMVVM.Views.ParticularProcessView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:ProcessMVVM.Views     5        � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ ViewsStyling.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5    
   �� 5!      $��* �6   �� 5"      $��* �6   .+�5$   
   �� $��Process Information��6      Headers#��[  6/   $��2��6P   �� 5%   
   $��1��6     BorderTheme#��[ 6   ._�5&      �� $��Process Name��6     Regular#��[ 6,   5'      �� 5(   
   $��2��6   #��[ 6   ._�5)      �� $��
Process ID��6   #��[ 6*   5*      �� 5+   
   $��3��6   #��[ 6   ._�5,      �� $��Protocol��6   #��[ 6(   5-      �� 5.   
   $��4��6   #��[ 6   ._�5/      �� $��Local IP��6   #��[ 6(   50      �� 51   
   $��5��6   #��[ 6   ._�52      �� $��
Local Port��6   #��[ 6*   53      �� 54   
   $��6��6   #��[ 6   ._�55      �� $��	Remote IP��6   #��[ 6)   56      �� 57   
   $��7��6   #��[ 6   ._�58      �� $��Remote Port��6   #��[ 6+   59      �� 5:   
   $��8��6   #��[ 6   ._�5;      �� $��Status��6   #��[ 6&   5<      �� 5>   
   $��9��6   $��2��6   #��[ 62   ._�5?      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5@      ��   ButtonTheme#��[ 6   $��⏮️��6>   ��6K   �� *PreviousCommand+�� 5A      #��[ 6I   $��Center=�6j   ��6   �� *SelectedProcess.ProcessName+6j   �� 5B      #��[ 6   $��⏭️��6>   ��6K   �� *NextCommand+5C      5D      �� 5E   
   $��10��6   $��2��6   #��[ 63   ._�5F      �� $��5q�6   $��Center=�6$   .+�5G      �� $"��Number Of Related Processes:��6   #��[ 6@   �� 5H      -   5        $��ProcessCount��5H   g   #��[ 6F   ��6   �� *AssociatedProcessesCount+6g   5I      5J      �� 5K   
   $��11��6   #��[ 6   $��2��6D   ._�5L      �� $ 
Horizontal=�6   $��Center=�62   .+�5M      �� $��Close��6   #��[ 6J   ��6)   �� *CloseCommand+��6o   ��  �� RelativeSource ��  �� AncestorType" ��� 5N      $��Associated Processes��6   #��[ 6�   ��68   �� *AssociatedProcessesCommand+��6g   ��  �� ElementName$ ProcessCount��6�   5O      5P      �� 5R   
   $��1��6   $��1��6   #��[ 6.   ._�5S      �� #��[ 6E   ��6   �� *SelectedProcess.ProcessName+6E   5T      �� 5U   
   $��2��6   $��1��6   #��[ 6.   ._�5V      �� #��[ 6C   ��6   �� *SelectedProcess.ProcessID+6C   5W      �� 5X   
   $��3��6   $��1��6   #��[ 6.   ._�5Y      �� #��[ 6B   ��6   �� *SelectedProcess.Protocol+6B   5Z      �� 5[   
   $��4��6   $��1��6   #��[ 6.   ._�5\      �� #��[ 6A   ��6   �� *SelectedProcess.LocalIP+6A   5]      �� 5^   
   $��5��6   $��1��6   #��[ 6.   ._�5_      �� #��[ 6C   ��6   �� *SelectedProcess.LocalPort+6C   5`      �� 5a   
   $��6��6   $��1��6   #��[ 6.   ._�5b      �� #��[ 6B   ��6   �� *SelectedProcess.RemoteIP+6B   5c      �� 5d   
   $��7��6   $��1��6   #��[ 6.   ._�5e      �� #��[ 6D   ��6   �� *SelectedProcess.RemotePort+6D   5f      �� 5g   
   $��8��6   $��1��6   #��[ 6.   ._�5h      �� #��[ 6@   ��6   �� *SelectedProcess.Status+6@   5i      5j      5k      