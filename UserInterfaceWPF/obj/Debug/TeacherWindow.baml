   M S B A M L   `   `   `  ����K  GUserInterfaceWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:UserInterfaceWPFUserInterfaceWPF  5   	   M+clr-namespace:UserInterfaceWPF.TeacherViewsUserInterfaceWPF.TeacherViews  5   	   U/clr-namespace:UserInterfaceWPF.TeacherViewModel!UserInterfaceWPF.TeacherViewModel  5   	   $    UserInterfaceWPF.TeacherWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:UserInterfaceWPF     5   	   =views+clr-namespace:UserInterfaceWPF.TeacherViews     5   	   E	viewModel/clr-namespace:UserInterfaceWPF.TeacherViewModel     5   	   -   5          � Title$  TeacherWindow��5
   	   $	��450��6   $	��800��6,    � DataContext 5      -   'UserInterfaceWPF.TeacherWindowViewModel  5       � 	Resources 5       �� DataType7   1UserInterfaceWPF.TeacherViewModel.CourseViewModel.   (UserInterfaceWPF.TeacherViews.CourseView5   /UserInterfaceWPF.TeacherViewModel.TestViewModel,   &UserInterfaceWPF.TeacherViews.TestView8   2UserInterfaceWPF.TeacherViewModel.MessageViewModel/   )UserInterfaceWPF.TeacherViews.MessageView8  2UserInterfaceWPF.TeacherViewModel.ProfileViewModel/	   )UserInterfaceWPF.TeacherViews.ProfileView;
  5UserInterfaceWPF.TeacherViewModel.NewMessageViewModel2   ,UserInterfaceWPF.TeacherViews.NewMessageView:  4UserInterfaceWPF.TeacherViewModel.NewCourseViewModel1   +UserInterfaceWPF.TeacherViews.NewCourseViewA   ;UserInterfaceWPF.TeacherViewModel.NewTeachingTopicViewModel8   2UserInterfaceWPF.TeacherViews.NewTeachingTopicView8   2UserInterfaceWPF.TeacherViewModel.NewTestViewModel/   )UserInterfaceWPF.TeacherViews.NewTestView��%X  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5      *, +)(�� �     5      *,
 +)(�� �     5"      *, +)(�� ,    5%      *, +)(�� ^    5(      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5      	  5      �� 5   
   " 
 6   .R�5         5!      �� 5"   
   "  6   .R�5#        5$      �� 5%   
   "  6   .R�5&        5'      �� 5(   
   "  6   .R�5)        5*      5+      .��5-      � ���#d6e7f9 � RowDefinitions 5.   
   �� 5/      $
��Auto �6   �� 50      $
��Auto �6   �� 51      $
��Auto �6   �� 52      $
��Auto �6   �� 53      $
��Auto �6   �� 54      $
��Auto �6   �� 55      $
��Auto �6   �� 56      $
��Auto �6   .+�59   
   ]� $��0��6   $��5q�6!   .+�5:      o� $	��Top=�6   .@�5;      m� $��Course and topic��6    m� CommandParameter$ Course��5<       m� Command 5;   5   �� *
NavCommand+5<      m� 5=      $��Tests��6   $
 Test��5>       5=   *   �� *
NavCommand+5>      m� 5?      $��Messages��6   $ Message��5@       5?   -   �� *
NavCommand+5@      m� 5A      $��Profile��6   $ Profile��5B       5A   ,   �� *
NavCommand+5B      m� 5C      $��New Message��6   $ 
NewMessage��5D       5C   0   �� *
NavCommand+5D      m� 5F      $��
New Course��6   $ 	NewCourse��5G       5F   /   �� *
NavCommand+5G      m� 5I      $��	New topic��6   $ TeachingTopic��5J       5I   .   �� *
NavCommand+5J      m� 5L      $��New Test��6   $ NewTest��5M       5L   -   �� *
NavCommand+5M      5N      5O      � 5P   
   $��1��6   .+�5U      �� $��3��6B   ��6   �� *CurrentViewModel+6B   5V      5W      5X      