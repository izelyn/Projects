#include <conio.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>


/////////////bagli liste
struct sehir{
	
	int plk;
	char *ad;
	char *bolge;
	int kosay;
		
};

/////////////degisken
struct sehir kayit[81];
struct sehir *atama(int plak,char *adi,char *bol,int ksay);
FILE *f2;
int i,j,plaka,sayac,y,v,secim,secim2,no,az,ck,secim3,secim4,z=0,w,bonus,dizi[81][10],m=0,n=0,a=0;
char *ismi,*bolgesi,*ayrim,satir[500],*orti,*komsusu[10],*hesap[81][10];

void listele();

//////////////////baglý list atama fonk

struct sehir *atama(int plak, char* adi, char* bol, int ksay){
    struct sehir *atanmis=(struct sehir *) malloc(sizeof(struct sehir));
	atanmis->plk=plak;
	atanmis->ad=strdup(adi);
	atanmis->bolge=strdup(bol);
	atanmis->kosay=ksay;
	
	return atanmis;
}
 
//////////kelime ayrim fonk
void olustur(char *satir){
y=0,sayac=0,m=0,n=0;
	
	ayrim=strtok(satir,",");
	while(ayrim!=NULL){
	if(y==0){
		plaka=(int)strtod(ayrim,NULL);
	}
	else if(y==1){
		ismi=ayrim;
		
	}
	else if(y==2){
		bolgesi=ayrim;
	}
	
	else{
	 
	  
	
		sayac++;

} 	 
	ayrim=strtok(NULL,",");
 y++; 
 } 

	kayit[v]=*atama(plaka,ismi,bolgesi,sayac);
	v++;



}
//////////okunan dosyayý yazdýran fonk
void listele(){

	
for(j=0;j<81;j++){
	if(kayit[j].ad!=NULL){
		fprintf(f2,"%d %s %s %d\n",kayit[j].plk,kayit[j].ad,kayit[j].bolge,kayit[j].kosay);
}
}}
///////////////2.islem fonk
void sehirara(char *pu){
	
for(i=0;i<81;i++){
	if(strcmpi(kayit[i].ad,pu)==0){
		fprintf(f2,"aranan sehrin plakasi: %d\nbulundugu bolge:%s\nkomsu sayisi:%d\n",kayit[i].plk,kayit[i].bolge,kayit[i].kosay);
	}
	}
	
	}

void plakaara(int a){
	for(i=0;i<81;i++){
		if(kayit[i].plk==a){
			fprintf(f2,"aranan sehrin adi: %s\nbulundugu bolge:%s\nkomsu sayisi:%d\n",kayit[i].ad,kayit[i].bolge,kayit[i].kosay);
	
}}}
/////////////3.islem fonk
void sehirsil(char *il){
		
	
	for(i=0;i<81;i++){

		if(strcmpi(kayit[i].ad,il)==0){
			fprintf(f2,"silinen sehrin plakasi: %d\nadi: %s\nbulundugu bolge:%s\nkomsu sayisi:%d\n",kayit[i].plk,kayit[i].ad,kayit[i].bolge,kayit[i].kosay);
			w=i;
		
		}
		
		}
	for(;w<80;w++){
		
			kayit[w].plk=kayit[w+1].plk;
			kayit[w].ad=kayit[w+1].ad;
			kayit[w].bolge=kayit[w+1].bolge;
			kayit[w].kosay=kayit[w+1].kosay;
		
		
			}
			kayit[w].plk=NULL;
			kayit[w].ad=NULL;
			kayit[w].bolge=NULL;
			kayit[w].kosay=NULL;
		

	
	 

	}
	////////////4. islem fonk
void bolgelist(char *bolg){
	
	int p=0;
	fprintf(f2,"%s bolgesinde bulunan sehirler:\n",bolg);
	for(i=0;i<81;i++){
		
		if(strcmpi(bolg,kayit[i].bolge)==0){
			p++;
			fprintf(f2,"sehrin adi: %s\nplakasi:%d\nkomsu sayisi:%d\n",kayit[i].ad,kayit[i].plk,kayit[i].kosay);
		}
	}
	printf("bolgede %d adet sehir vardir.\n",p);
	fprintf(f2,"bolgede %d adet sehir vardir.\n",p);
}





////////////5. islem fonk

void komsa(int b,int c){
	int d=0;
	fprintf(f2,"komsu sayilari esit sehirler:\n");

	for(i=0;i<81;i++){
	if(kayit[i].kosay>=b&&kayit[i].kosay<=c){
		d++;
		fprintf(f2,"sehrin adi: %s\nplakasi:%d\nbulundugu bolge:%s\nkomsu sayisi:%d\n",kayit[i].ad,kayit[i].plk,kayit[i].bolge,kayit[i].kosay);
	}


}
printf("en az %d en cok %d komsusu olan %d sehir vardir.\n",az,ck,d);
fprintf(f2,"en az %d en cok %d komsusu olan %d sehir vardir.\n",az,ck,d);
}
//////////dosya okuyan fonk
void dosyaoku(){

	FILE *f=fopen("sehirler.txt","r");
	f2=fopen("cikti.txt","a");
	 while(fgets(satir, sizeof(satir), f)){
		olustur(satir);
		
	}
	fclose(f);
	 
}

///////////////main fonksiyonu

int main() { 

	
	char *il=(char *)malloc(sizeof(char)*20);
	char *ko=(char *)malloc(sizeof(char)*20);
	char *blg=(char *)malloc(sizeof(char)*20);
	char *c=(char *)malloc(sizeof(char)*20);
	dosyaoku();
	listele();

	
	printf("yapmak istediginiz islemi secin:\n");
	printf("sehir ismi veya plakasi ile arama yapmak icin 2'yi\n");
	printf("sehir kaydini silmek icin 3'u\n");
	printf("istenen bolgedeki sehirlerin listesi icin 4'u:\n");
	printf("komsu sayisi ayni olan sehirlerin listesi icin 5'i:\n");
	printf("cikis icin 9'u seciniz.\n");
	
	while(1){
	printf("seciminiz:");
	
	scanf(" %d",&secim);
	fprintf(f2,"seciminiz:%d\n",secim);

		
if(secim==2){	
		printf("sehir ismi ile arama icin 1\n plaka no ile arama icin 2\n");
		scanf("%d",&secim2);
			if(secim2==1){
			printf("aranacak sehir ismini girin:\n");
			scanf("%s",il);
			
		sehirara(il);
	 

				
		}
		else if(secim2==2){
			printf("aranacak plaka noyu girin:\n");
			scanf("%d",&no);
			plakaara(no);
		} else {printf("hatali giris.\n");
	}
	}
	else if(secim==3){
		
			printf("silmek istediginiz sehri girin:\n");
			
			scanf("%s",il);
	sehirsil(il);
	
	
	}
	
	else if(secim==4){
		
		printf("sehir bilgileri istenen bolgeyi girin:\n");
		scanf("%s",blg);
		bolgelist(blg);
		
		
	}
 else if(secim==5){
 	printf("komsu sayisi deger araligini sirasiyla girin az/cok\n");
 	scanf("%d %d",&az,&ck);
 
 	komsa(az,ck); 
 }
	
	
	else if(secim==9){
		printf("cikisa bastiniz.\n");
		fprintf(f2,"cikisa bastiniz.\n");
	break;
	}
	else {
		printf("\nhatali secim yaptiniz.\n");
		fprintf(f2,"\nhatali secim yaptiniz.\n");
		break;}
		
}
 
	return 0;
}
