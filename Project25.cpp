#include <iostream>
using namespace std;
int main() {
	
 int sayilar[5];
 cout << "5 Tane Tamsayi Girmelisiniz!" << endl;



 
 // girilen degerleri bir int dizisinde sakla
 


 for (int i = 0; i < 5; ++i) {

    
	 
 cout << i + 1 << ". Sayi giriniz..:";

 
 cin >> sayilar[i];
 
 }
 cout << endl << "Girilen sayilar: ";
 
 
 // dizi elemanlarini ekranda yazdir
 
 for (int n = 0; n < 5; ++n) {
 cout << sayilar[n] << " ";
 }
 system("pause");

 return 0;
 
}
