   M S B A M L   `   `   `  ����K  GUserInterfaceWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:UserInterfaceWPF.TeacherViewsUserInterfaceWPF.TeacherViews  5      ,    &UserInterfaceWPF.TeacherViews.TestView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:UserInterfaceWPF.TeacherViews     5      .��5	      � ���#B8FFF3.+�5
   
   ��   �� Orientation$  Vertical=�6   .+�5      �� $  
Horizontal=�6   �� 5      $  
Horizontal=�6   $��Center=�62   .+�5      �� -   5         ��Name$ 	btnReport��5      $��40��6,   $��Report��69   $��20(�6J   $	��252��6X   ��6e   �� *ReportCommand+5      �� 5      $��10��6   6&   &   System.Windows.Controls.DataGrid  5         AutoGenerateColumns .     CanUserAddRows .  $	��240��6�   $	��750��6�   ��64   ��  �� Path$ AllTests� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6�   �� *SelectedTest+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
Test name ��6)   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 150 6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
TestName+6Z     5      $	 Course name ��6)   $	
 150 6^    6?   �� *
CourseName+6^     5      $	 
Max points��6)   $	
 150 6\    6=   �� *
TestPoints+6\     5      $	 	Questions��6)   $	
 150 6_    6<   �� *QuestionNumber+6_   5      �� 5      $��50��6   6&   5!      5#      5$      