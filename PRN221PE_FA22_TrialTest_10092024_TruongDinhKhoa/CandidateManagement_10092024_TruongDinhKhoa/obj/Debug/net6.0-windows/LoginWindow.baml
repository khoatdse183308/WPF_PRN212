   M S B A M L   `   `   `  ����f  bCandidateManagement_10092024_TruongDinhKhoa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:CandidateManagement_10092024_TruongDinhKhoa+CandidateManagement_10092024_TruongDinhKhoa  5   	   =    7CandidateManagement_10092024_TruongDinhKhoa.LoginWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Klocal9clr-namespace:CandidateManagement_10092024_TruongDinhKhoa     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65    � WindowStyle$
 None=�6Z    � 	Resources 5	         
LabelStyle �� 
TargetType �� Property �� Value3  -System.Windows.Media.Effects.DropShadowEffect   Color   	Direction	   ShadowDepth
   Opacity  ButtonStyle �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value��%0  &	        &	     �� 5
   
   " ��6#   .�5      ��  � ��
 �����6+   �� 5       � ��$ Segoe UI)�6+   �� 5       � ��$ SemiBold"�6+   �� 5       �@J�Effect 5        5      $ Black��6'   $	 320Q�65   $	 3Q�6E   $	
 0.5Q�6U   5      5      �� 5   
   " ��6$   .�5      ��  � �� �#4A90E26+   �� 5       � ��
 �����6+   �� 5       � ��$ 0q�60   �� 5       � ��$ 20,10q�6(   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   $ 5��5   !   $��0q�5   !   ._�5       �� $��Center=�6/   $��Center=�5!   -   5"      5#      5%       5&      P� 5'       �@J�IsMouseOver$
 True��61   . �5(      ��  � �� �#357ABD63   5)      5+      5,      .��5.      � ��5/   
   �� 50       �� ImageSource$ /loginwindow.jpg��6   .+�53   
   �� $��Email:��6   #��[  6!   $��97,92,555,284q�54      $��16(�6'   �� 56   
   -   5         ��Name$ txtEmail��56      $
��Left=�57      $��
207,91,0,0q�58       �� TextWrapping$
 Wrap=�59      $	��Top=�5:      $	��490��5;      $��16(�5<      $��34��5=      $��admin@hr.com.vn��5>      �� 5@   
   $��	Password:��6   #��[  6$   $��93,191,555,192q�5A      $��16(�6(   �� 5C   
   $��LOGIN SCREEN��6   #��[  6'   $
��Left=�5D      $��
309,32,0,0q�5E      $	��Top=�5F      $��54��5G      $	��219��5H      $��30(�5I      $
��Bold"�5J      �� 5L   
   -   5         ��Name$ btnLogin��5L      $��Login��5M      #��[ 5N      $
��Left=�5O      $��244,308,0,0q�5P      $	��Top=�5Q      $��63��5R      $	��130��5S      $��16(�5T      $
��Bold"�5U      6#   �� 5W   
   -   5        $ 	btnCancel��5W      $��Cancel��5X      #��[ 5Y      ���#E74C3C$
��Left=�5[      $��472,308,0,0q�5\      $	��Top=�5]      $��63��5^      $	��146��5_      $��16(�5`      $
��Bold"�5a      6#   G� 5c   
   -   5         G�Name$ txtPassword��5c      $
��Left=�5d      $��207,195,0,0q�5e      $	��Top=�5f      $	��490��5g      $��26��5h       G� Password$
 123@��5i      5j      5k      