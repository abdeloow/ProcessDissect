   M S B A M L   `   `   `  ����F  BProcessMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProcessMVVM.ViewsProcessMVVM.Views  5           ProcessMVVM.Views.HomeView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:ProcessMVVM.Views     5        � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ ViewsStyling.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��Active TCP Processes��6      Headers#��[  60   �� 5   
   $��1��6     BorderTheme#��[ 6   $��Center=�6C   ._�5      ��  �� Orientation$ 
Horizontal=�6   $��10q�62   .+�5      �� $��Search for a Process :��6     Regular#��[ 6:   $��Center=�6[   �� 5      $	��190��6i   $��Center=�6v   $��Center=�6�   ��6   �� *SearchValue+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   5      5      �� 5   
   $��2��6   #��[ 6   $��Center=�6C   ._�5       �� -   5         ��Name$ ProcessesList��5       $��10q�6�   ��6.   �� *ActiveTcpProcesses+ �� SelectedItem 6Y   �� *CurrentTcpProcess+$ TwoWay=�	 �� View	 5!      �� 5"      .P�5#      �� $��Process Name��6)   
 �� CellTemplate
 5$      �� 5%   "   .R�5&   &   �� #��[ 6M   ��60   �� *ProcessName+6M   5'   #   5)      �� 5*      $��
Process ID��6)   
 5+      �� 5,   "   .R�5-   &   �� #��[ 6K   ��60   �� *	ProcessID+6K   5.   #   50      �� 51      $��Protocol��6)   
 52      �� 53   "   .R�54   &   �� #��[ 6J   ��60   �� *
Protocol+6J   55   #   57      �� 58      $��Local IP��6)   
 59      �� 5:   "   .R�5;   &   �� #��[ 6I   ��60   �� *	LocalIP+6I   5<   #   5>      �� 5?      $��
Local Port��6)   
 5@      �� 5A   "   .R�5B   &   �� #��[ 6K   ��60   �� *	LocalPort+6K   5C   #   5E      �� 5F      $��	Remote IP��6)   
 5G      �� 5H   "   .R�5I   &   �� #��[ 6J   ��60   �� *
RemoteIP+6J   5J   #   5L      �� 5M      $��Remote Port��6)   
 5N      �� 5O   "   .R�5P   &   �� #��[ 6L   ��60   �� *
RemotePort+6L   5Q   #   5S      �� 5T      $��Status��6)   
 5U      �� 5V   "   .R�5W   &   �� #��[ 6H   ��60   �� *Status+6H   5X   #   5Z      5[      5]      5^      �� 5_   
   $��3��6   #��[ 6   $��Center=�6C   ._�5`      �� .+�5a      �� $��Total Of Active Processes��6   #��[  6=   �� 5b      #��[ 6:   ��6   �� *ProcessCount+6:   �� 5c      #��[ 6K   ��6   �� *CurrentTcpProcess.ProcessName+6K   5d      5e      �� 5f   
   $��4��6   #��[ 6   $��Center=�6C   ._�5g      �� $ 
Horizontal=�6   .+�5h      ��   ButtonTheme#��[ 6   $��Clear��6>   ��6N   �� *ClearCommand+��6o   ��  �� ElementName$ ProcessesList���� 5i      #��[ 6   $��Refresh��6>   ��6P   �� *RefreshCommand+�� 5j      #��[ 6   $��Details��6>   ��6P   �� *DetailsCommand+��6s   �� *SelectedValue+$ ProcessesList��5k      5l      5m      5n      