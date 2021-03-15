#define V 81
#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include <limits.h>
#include <stdbool.h>

int dizi[V][V],plk[81],uzaklik[81],di[10],m,k,l,i,j,say,p,s,sy,v,gc=0,a=1,yol[11];
bool ziyaret[81];
     

char  cum[5000],cumle[5000],*adi[81],*ayri,*ay,*is,*ptr;
FILE *f,*f1; 

void ayiri(char *cum){
    ay=strtok(cum,",");
    while(ay!=NULL){
    if(k!=81){
        dizi[m][k]=(int)strtod(ay,NULL);
        dizi[k][m]=dizi[m][k];
    }
    else if(k==81){
        k=0;
        m++;
    }
	k++;
    ay=strtok(NULL,",");

    
}
}
void okum(){
f=fopen("uzak.txt","r");
while(fgets(cum,sizeof(cum),f)!=NULL){

		ayiri(cum);
	}


}

void ayir(char *cumle){
l=0;	
	ayri=strtok(cumle,",");
	while(ayri!=NULL){
		if(l%2==0){
			plk[i]=(int)strtod(ayri,NULL);
			
		}
		else {
			adi[i]=ayri;
			i++;
					}
					
	
		ayri=strtok(NULL,",");
		l++;
	}
	
}

void oku(){
	f1=fopen("sehir.txt","r");
	while(fgets(cumle,sizeof(cumle),f1)!=NULL){
		ayir(cumle);
	}
}
int minDist(int uzaklik[], bool ziyaret[])
{  

   int min = INT_MAX, min_index;

   for (v = 0; v < V; v++)
     if (ziyaret[v] == false && uzaklik[v] <= min)
         min = uzaklik[v], min_index = v;


   return min_index;
}
int printSolution(int uzaklik[], int n)
{   
   printf("Dugumlerin ana kaynaga olan uzakligi\n");
   for (i = 0; i < 81; i++)
   {
     printf("%d -->  %d\n", i+1,uzaklik[i]);
   }
}
void dijkstra(int graph[V][V], int bas)
{
      


     for (i = 0; i < V; i++)
      {  uzaklik[i] = INT_MAX, ziyaret[i] = false;
}

     uzaklik[bas-1] = 0;
     int count ;

     for ( count = 0; count < V-1; count++)
     {

       int u = minDist(uzaklik, ziyaret);


       ziyaret[u] = true;
       int v;

       for ( v = 0; v < V; v++)

{
         if (!ziyaret[v] && graph[u][v] && uzaklik[u] != INT_MAX
                                       && uzaklik[u]+graph[u][v] < uzaklik[v])
{

            uzaklik[v] = uzaklik[u] + graph[u][v];

     }
}
}
   //printSolution(uzaklik, V);
}

void mesafe(int di[10],int uzaklik[81]){
	for(i=9;i>1;i--){
	for(j=0;j<i;j++){
	if(di[j]==di[i] || di[j]==0){
		for(s=j;s<9;s++){
                di[s]=di[s+1];
                di[s+1]=NULL;
		}	}	}	}
	



for(i=1;i<10;i++){
	for(j=0;j<i;j++){
if(di[i]!=0){
	if(uzaklik[di[j]-1]>uzaklik[di[i]-1]){
		
		
		gc=di[i];
		di[i]=di[j];
		di[j]=gc;

	}
}
}
}


}



 
int main(int argc, char *argv[]) {
	oku();
	okum();
	

is=(char *)malloc(sizeof(char)*20);
	for(i=0;i<81;i++){
//	printf("%d  %s\n",plk[i],adi[i]);
	}
	

for(i=0;i<81;i++){
	// printf("\n");
	for(j=0;j<81;j++){
	//	printf("%d ",dizi[i][j]);	}
}
}

	printf("\nteslimat icin sehir ismi veya plaka girmeniz gerekmektedir.\n");
	printf("sehir ismi girmek icin 1 i\nplaka girmek icin 2 yi\neklemeyi durdurmak icin 3 u tuslayin.\n");
	for(say=0;say<9;say++){
	printf("seciminiz:");
	scanf("%d",&sy);
	if(sy==1){
		printf("sehir ismi girin:");
		scanf("%s",is);		
		for(i=0;i<81;i++){
			if(strcmpi(adi[i],is)==0){
			 
				di[say]=plk[i];
				 
			}
		}
		
		
	}
	else if(sy==2){
		printf("sehir plakasi girin:");
		scanf("%d",&p);
		for(i=0;i<81;i++){
			if(plk[i]==p){
				di[say]=plk[i];
				 
			}
		}
	}
	else if(sy==3){
		break;
		
	}
	else {	
		printf("hatali giris yaptiniz.\n");
	
	}
}
dijkstra(dizi,41);
yol[0]=41,yol[10]=41;
mesafe(di,uzaklik);
while(di[0]!=0){
	dijkstra(dizi,di[0]);
	yol[a]=di[0];
	di[0]=0;
	mesafe(di,uzaklik);
	
	a++;
}
printf("(her kargo araci icin baslangic ve bitis sehri kocaelidir.)\n");
printf("firmamizdan cikan kargo aracinin sehir guzergahi:");
for(i=1;i<11;i++){
	if(yol[i]!=0&&yol[i]!=41){
	printf("%d  ",yol[i]);}
	
}
printf("\n\n\nBIZI TERCIH ETTIGINIZ ICIN TESEKKUR EDERIZ...");
return 0;
}   
