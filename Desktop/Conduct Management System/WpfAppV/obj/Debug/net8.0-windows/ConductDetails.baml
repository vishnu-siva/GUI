   M S B A M L   `   `   `  ����R  NConductManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ConductManagementSystemConductManagementSystem  5   	   ,    &ConductManagementSystem.ConductDetails   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:ConductManagementSystem     5   	     � Title$  ConductDetails��5   	   $	��450��6    $	��800��6-   ���#80BED2 � WindowStartupLocation$ CenterScreen=�5	   
   .��5
      � .+�5   
   �� $
��Name��6   $��14(�6   $��
0,8,125,-8q�6-   �� 5   
   -   5         ��Name$ txtName��5      $
��Left=�6#   $	��Top=�6>   $	��200��6V   $��
150,22,0,0q�6b   �� 5   
   $��Email Address��6   $��14(�6(   $��
0,40,0,-40q�66   �� 5   
   -   5        $ txtEmail��5      $
��Left=�6$   $	��Top=�6?   $	��200��6W   $��
150,57,0,0q�6c   �� 5   
   $��
Contact No��6   $��14(�6%   $��
0,80,0,-80q�63   �� 5   
   -   5        $ 
txtContact��5      $
��Left=�6&   $	��Top=�6A   $	��200��6Y   $��
150,95,0,0q�6e    J� RenderTransformOrigin$ 0.495,0.837&�6y   �� 5   
   $��Address��6   $��14(�6"   $��5,118,-5,-118q�60   �� 5   
   -   5        $ 
txtAddress��5      $
��Left=�6&   $	��Top=�6A   $	��200��6Y   $��150,128,0,0q�6e   �� 5   
   -   5        $��Add Conduct��5      $
��Left=�6'   $	��Top=�6C   $	��100��6[   $��630,277,0,0q�6g   $ 0.387,-1.476&�6�   �� 5   
   -   5        $��Update Conduct��5      $
��Left=�6*   $	��Top=�6E   $	��100��6]   $��630,315,0,0q�6i   $ 0.531,-0.755&�6�   �� 5   
   -   5        $��Delete Conduct��5      $
��Left=�6*   $	��Top=�6E   $	��100��6]   $��630,352,0,0q�6i   6~   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ ConductGrid��5      $	��560��6(   $��24,180,216,41q�64      AutoGenerateColumns$ False��5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6P   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 62   �� *	ConductID+6P     5      $
 Name��6%   $	 150 6L   	 63   �� *Name+6L     5       $ Email��6%   $	 100 6N   	 64   �� *Email+6N     5!      $ Contact��6%   $	 120 6R   	 66   �� *	Contact+6R     5"      $ Address��6%   $	 150 6R   	 66   �� *	Address+6R   5$      �� 5%   
   -	   5        ���#1574d9$��Log Out��5%   '   $
��Left=�6:   $	��Top=�6U   $	��100��6m   $��
680,25,0,0q�6y   6�   5&      5'      