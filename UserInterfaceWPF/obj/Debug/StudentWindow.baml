   M S B A M L   `   `   `  ����K  GUserInterfaceWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:UserInterfaceWPFUserInterfaceWPF  5   	   M+clr-namespace:UserInterfaceWPF.StudentViewsUserInterfaceWPF.StudentViews  5   	   U/clr-namespace:UserInterfaceWPF.StudentViewModel!UserInterfaceWPF.StudentViewModel  5   	   $    UserInterfaceWPF.StudentWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:UserInterfaceWPF     5   	   =views+clr-namespace:UserInterfaceWPF.StudentViews     5   	   E	viewModel/clr-namespace:UserInterfaceWPF.StudentViewModel     5   	   -   5          � Title$  StudentWindow��5   	   $	��450��6   $	��800��6,    � DataContext 5      -   'UserInterfaceWPF.StudentWindowViewModel  5   
    J� InputBindings 5      �� 5   
   
 �� Key$ F1��6    �� CommandParameter$ Courses��6=    �� Command 6   �� *
NavCommand+6=   �� 5   
   $ F2��6   $ MyCourse��6=    6   �� *
NavCommand+6=   �� 5   
   $ F3��6   $ Tests��6=    6   �� *
NavCommand+6=   �� 5   
   $ F4��6   $ TestHistory��6=    6   �� *
NavCommand+6=    � 	Resources 5       �� DataType8  2UserInterfaceWPF.StudentViewModel.CoursesViewModel/   )UserInterfaceWPF.StudentViews.CoursesView:  4UserInterfaceWPF.StudentViewModel.MyCoursesViewModel1   +UserInterfaceWPF.StudentViews.MyCoursesView5   /UserInterfaceWPF.StudentViewModel.TestViewModel,   &UserInterfaceWPF.StudentViews.TestView<  6UserInterfaceWPF.StudentViewModel.TestHistoryViewModel3	   -UserInterfaceWPF.StudentViews.TestHistoryView��%,  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5"      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5         5!      �� 5"   
   "  6   .R�5#      	  5$      5&      .��5'      �  � RowDefinitions 5(   
   �� 5)      $
��Auto �6   �� 5*      $
��Auto �6   �� 5+      $
��Auto �6   �� 5,      $
��Auto �6   �� 5-      $
��Auto �6   �� 5.      $
��Auto �6   �� 5/      $
��Auto �6   �� 50      $
��Auto �6   .+�52   
   ]� $��0��6   $��5q�6!   .+�53      o� $	��Top=�6   .@�54      m� $��Courses��6   	 m� CommandParameter$	 Courses��55      
 m� Command
 54   ,   �� *
NavCommand+55      m� 56      $��
My courses��6   $	 MyCourse��57      
 56   /   �� *
NavCommand+57      m� 58      $��Tests��6   $	 Tests��59      
 58   *   �� *
NavCommand+59      m� 5:      $��Tests history��6   $	 TestHistory��5;      
 5:   2   �� *
NavCommand+5;      5<      5=      � 5>   
   $��1��6   .+�5C      �� $��3��6B   ��6   �� *CurrentViewModel+6B   5D      5E      5F      