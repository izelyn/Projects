//160201008 ÝZELYÖN izelyon6@mail.com
//160201022 FATMASÖNMEZ fatma_sonmez98@hotmail.com
#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>
#include <string.h>

int main() { for(;;){
	//deðiþken tanýmlamalarý
	int isl=0,s,s1,k,k1,i=0,j=0,sayi,bx,by,bz,yarc,d,x1,y1,z1,r=0,t,q,b1,u=0;
	char num[10],yor[50],ver[10],alan[10],veri[2][10],al[40],su[10];
	double topus;
	float x,y,z,max,maxx,maxy,maxz,min=100,minx=100,miny=100,minz=100,kupmax,kupmin,uz,ort,top=0;
	float noktx[100000],nokty[100000],noktz[100000];
   	FILE *f; 
   	FILE *o;
   	o=fopen("output.txt","a");
   	//dosya seçimi
   	printf("islem yapilacak dosyayi secin:\n");
   	printf("veriler1 icin 1\nveriler2 icin 2");
   	printf("(dosya secim menusunden cikis icin 7):");
   	scanf("%d",&d);
	   if(d==7){
	   fprintf(o,"dosya secim menusunden cikis yapildi.\n");
	   break;
}
   	fprintf(o,"%d. dosya secildi\n",d); 
   	
	   //1. dosya girdi koþulu
	if(d==1){
		int a[10000],b[10000],c[10000];
    	f=fopen("veriler1.txt","r");
    	while(!feof(f)){
    		fscanf(f,"%c",&yor[r]);
    		if(yor[r]=='\n'){
    			break;
}
			r++;
} 
		fscanf(f,"%s %d",&ver,&t);
		fscanf(f,"%s",&alan);
		for(q=0;;q++){
			fscanf(f,"%c",&al[q]);
			if(!isspace(al[q])){
			su[u]=al[q];
			u++;
}
			if(al[q]=='\n'){
				break;
} 
			
} 
		fscanf(f,"%s  %d",&num,&sayi); 
		fscanf(f,"%s %s",&veri[0],&veri[1]);
		b1=strlen(su);
		fprintf(o,"dosya %s %d olarak tanimlanmistir\n",ver,t);
		if(b1==6){
			fprintf(o,"dosya koordinatlara ek renk bilgisi ile verilmistir\n");
}
		else if(b1==3){
			fprintf(o,"dosya koordinat bilgileri ile verilmistir\n");
}
		else{printf("hata");
}
	
   		fprintf(o,"dosyada %d adet nokta vardir\n",sayi);

		while(!feof(f)){
        	fscanf(f,"%f %f %f",&noktx[i],&nokty[i],&noktz[i]);
        	fscanf(f,"%d %d %d\n",&a[i],&b[i],&c[i]);
       		i++;
}
for(i=0;i<10;i++){su[i]=NULL;
}
} //2. dosya girdi koþulu
	else if(d==2){
		f=fopen("veriler2.txt","r");
		while(!feof(f)){
    		fscanf(f,"%c",&yor[r]);
    		
    		if(yor[r]=='\n'){
    			break;
} 
			r++;
} 
		fscanf(f,"%s %d",&ver,&t);
		fscanf(f,"%s",&alan);
	
	for(q=0;;q++){
			fscanf(f,"%c",&al[q]);
			if(!isspace(al[q])){
			su[u]=al[q];
			u++;
}
			if(al[q]=='\n'){
				break;
}  
} 
		fscanf(f,"%s  %d",&num,&sayi); 
		fscanf(f,"%s %s",&veri[0],&veri[1]);
		b1=strlen(su);
		fprintf(o,"dosya %s %d olarak tanimlanmistir\n",ver,t);
		if(b1==6){
			fprintf(o,"dosya koordinatlara ek renk bilgisi ile verilmistir\n");
}
		else if(b1==3){
			fprintf(o,"dosya koordinat bilgileri ile verilmistir\n");
}
		else {printf("hata");
}
		fprintf(o,"dosyada %d adet nokta vardir\n",sayi);
		while(!feof(f)){
        	fscanf(f,"%f %f %f",&noktx[j],&nokty[j],&noktz[j]);
		
			j++;	
} 
}//hata mesajlarý
	else {
		fprintf(o,"hatali secim yaptiniz\n"); 
		printf("hatali secim yaptiniz");
		break;
}
		
	//iþlem menüsü
	printf("en yakin en uzak nokta icin 2\n");
	printf("tum noktalarin oldugu kup icin 3\n");
	printf("kure icinde kalan noktalar icin 4\n");
	printf("noktalar arasindaki uzaklik ortalamasi icin 5\n");
 	for(;;){
		printf("yapilacak islemi secin");
		printf("(islem menusunden cikis icin 9):");
		scanf("%d",&isl);
		if(isl==9){
		fprintf(o,"islem menusunden cikis yapildi.\n");
		break;
}
		fprintf(o,"secim %d\n",isl);
		
		// en yakýn en uzak nokta iþlemi
	if(isl==2){
		for(i=0;i<sayi-1;i++){
			for(j=i+1;j<sayi;j++){
	
				x=pow((noktx[i]-noktx[j]),2);
				y=pow((nokty[i]-nokty[j]),2);
				z=pow((noktz[i]-noktz[j]),2);
				uz=sqrt((x+y+z));
				if(uz>max){
					max=uz;
					s=i;
					s1=j;
}
				else{
					max=max;
}
				if(uz<min){
					min=uz;
					k=i;
					k1=j;
}
				else{
					min=min;
}
} 
}  	 	fprintf(o,"en uzak mesafe=%f\n",max);
		fprintf(o,"en uzak nokt:%d %d\n",s+1,s1+1);
		fprintf(o,"en yakin mesafe=%f\n",min);
		fprintf(o,"en yakin nokt:%d %d\n",k+1,k1+1);
} //küp iþlemi
	else if(isl==3){
		for(i=0;i<sayi;i++){
			if(noktx[i]<minx){
				minx=noktx[i];
}
			else {
				minx=minx;
}
			if(nokty[i]<miny){
				miny=nokty[i];
}
			else {
				miny=miny;
}
			if(noktz[i]<minz){
				minz=noktz[i];
}
			else {
				minz=minz;
}
			if(noktx[i]>maxx){
				maxx=noktx[i];
}
			else {
				maxx=maxx;
}
			if(nokty[i]>maxy){
				maxy=nokty[i];
}
			else {
				maxy=maxy;
}
			if(noktz[i]>maxz){
				maxz=noktz[i];
}
			else {
				maxz=maxz;
}
}   fprintf(o,"x in max degeri:%f\n",maxx);
	fprintf(o,"y nin max degeri:%f\n",maxy);
	fprintf(o,"z nin max degeri:%f\n",maxz);
	fprintf(o,"x in min degeri:%f\n",minx);
	fprintf(o,"y nin min degeri:%f\n",miny);
	fprintf(o,"z nin min degeri:%f\n",minz);
		if(minx<=miny&&minx<=minz){
			kupmin=minx;
}
		if(miny<=minx&&miny<=minz){
			kupmin=miny;
}
		if(minz<=minx&&minz<=miny){
			kupmin=minz;
}
		if(maxx>=maxy&&maxx>=maxz){
			kupmax=maxx;
}
		if(maxy>=maxx&&maxy>=maxz){
			kupmax=maxy;
}
		if(maxz>=maxx&&maxz>=maxy){
			kupmax=maxz;
}
	fprintf(o,"tum noktalari icine alan kupun kose noktalari:\n");
	fprintf(o,"1. noktax:%f y:%f z:%f \n",kupmin,kupmin,kupmin);
	fprintf(o,"2. noktax:%f y:%f z:%f \n",kupmax,kupmin,kupmin);
	fprintf(o,"3. noktax:%f y:%f z:%f \n",kupmax,kupmax,kupmin);
	fprintf(o,"4. noktax:%f y:%f z:%f \n",kupmin,kupmax,kupmin);
	fprintf(o,"5. noktax:%f y:%f z:%f \n",kupmin,kupmin,kupmax);
	fprintf(o,"6. noktax:%f y:%f z:%f \n",kupmax,kupmin,kupmax);
	fprintf(o,"7. noktax:%f y:%f z:%f \n",kupmax,kupmax,kupmax);
	fprintf(o,"8. noktax:%f y:%f z:%f \n",kupmin,kupmax,kupmax);
} //kure iþlemi
	else if(isl==4){
		printf("kurenin x y ve z degerini ve yaricapini girin:\n");
		scanf("%d %d %d %d",&bx,&by,&bz,&yarc);
		fprintf(o,"kurenin x degeri %d\n",bx);
		fprintf(o,"kurenin y degeri %d\n",by);
		fprintf(o,"kurenin z degeri %d\n",bz);
		fprintf(o,"kurenin yarýcap degeri %d\n",yarc);
			for(i=0;i<sayi;i++){
				
				x=pow((noktx[i]-bx),2);
				y=pow((nokty[i]-by),2);
				z=pow((noktz[i]-bz),2);
				uz=sqrt((x+y+z));
				if(uz<yarc){
					fprintf(o,"%d. nokta verilen kurenin icindedir.\n",i);
					fprintf(o,"nokta bilgileri: %f  %f  %f\n",noktx[i],nokty[i],noktz[i]);
}
				else if(uz==yarc){
					fprintf(o,"%d. nokta verilen kurenin uzerindedir.",i);
					fprintf(o,"nokta bilgileri: %f  %f  %f\n",noktx[i],nokty[i],noktz[i]);
}
}

} //uzaklýklarýn ortalamasý iþlemi
	else if(isl==5){
		
		for(i=0;i<sayi-1;i++){
			for(j=i+1;j<sayi;j++){
				x1=noktx[i]-noktx[j];
				y1=nokty[i]-nokty[j];
				z1=noktz[i]-noktz[j];
				x=pow(x1,2);
				y=pow(y1,2);
				z=pow(z1,2);
				uz=sqrt((x+y+z));
				top+=uz;
}
}
	topus=sayi*(sayi-1)/2.0;
	ort=top/topus;
	fprintf(o,"noktalar arasi uzakliklarin ortalama degeri:%f\n",fabs(ort));
} 
 	else{
 		fprintf(o,"hatali islem sectiniz.\nlutfen tekrar dosya secimi yapin\n");
 		printf("hata:lutfen tekrar dosya secimi yapin.\n");
 		break;
} 
}	fclose(f);
	fclose(o);
}


	return 0;

}
/*//160201008 ÝZELYÖN izelyon6@mail.com
//160201022 FATMASÖNMEZ fatma_sonmez98@hotmail.com
#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>
#include <string.h>

void islem2(int sayi,float noktx[],float nokty[],float noktz[]){
	FILE *o;
	o=fopen("output.txt","a");
	int i,j,s,s1,k,k1;
	float x,y,z,max=0,min=100,uz;
	for(i=0;i<sayi-1;i++){
			for(j=i+1;j<sayi;j++){
	
				x=pow((noktx[i]-noktx[j]),2);
				y=pow((nokty[i]-nokty[j]),2);
				z=pow((noktz[i]-noktz[j]),2);
				uz=sqrt((x+y+z));
				if(uz>max){
					max=uz;
					s=i;
					s1=j;
}
				else{
					max=max;
}
				if(uz<min){
					min=uz;
					k=i;
					k1=j;
}
				else{
					min=min;
}
} 
}  	 	fprintf(o,"en uzak mesafe=%f\n",max);
		fprintf(o,"en uzak nokt:%d %d\n",s+1,s1+1);
		fprintf(o,"en yakin mesafe=%f\n",min);
		fprintf(o,"en yakin nokt:%d %d\n",k+1,k1+1);
}
void islem3(float noktx[],float nokty[],float noktz[],int sayi){
	FILE *o;
	o=fopen("output.txt","a");
	int i;
	float minx=100,miny=100,minz=100,maxx,maxy,maxz,kupmax,kupmin=100;
		for(i=0;i<sayi;i++){
			if(noktx[i]<minx){
				minx=noktx[i];
}
			else {
				minx=minx;
}
			if(nokty[i]<miny){
				miny=nokty[i];
}
			else {
				miny=miny;
}
			if(noktz[i]<minz){
				minz=noktz[i];
}
			else {
				minz=minz;
}
			if(noktx[i]>maxx){
				maxx=noktx[i];
}
			else {
				maxx=maxx;
}
			if(nokty[i]>maxy){
				maxy=nokty[i];
}
			else {
				maxy=maxy;
}
			if(noktz[i]>maxz){
				maxz=noktz[i];
}
			else {
				maxz=maxz;
}
}   fprintf(o,"x in max degeri:%f\n",maxx);
	fprintf(o,"y nin max degeri:%f\n",maxy);
	fprintf(o,"z nin max degeri:%f\n",maxz);
	fprintf(o,"x in min degeri:%f\n",minx);
	fprintf(o,"y nin min degeri:%f\n",miny);
	fprintf(o,"z nin min degeri:%f\n",minz);
		if(minx<=miny&&minx<=minz){
			kupmin=minx;
}
		if(miny<=minx&&miny<=minz){
			kupmin=miny;
}
		if(minz<=minx&&minz<=miny){
			kupmin=minz;
}
		if(maxx>=maxy&&maxx>=maxz){
			kupmax=maxx;
}
		if(maxy>=maxx&&maxy>=maxz){
			kupmax=maxy;
}
		if(maxz>=maxx&&maxz>=maxy){
			kupmax=maxz;
}
	fprintf(o,"tum noktalari icine alan kupun kose noktalari:\n");
	fprintf(o,"1. noktax:%f y:%f z:%f \n",kupmin,kupmin,kupmin);
	fprintf(o,"2. noktax:%f y:%f z:%f \n",kupmax,kupmin,kupmin);
	fprintf(o,"3. noktax:%f y:%f z:%f \n",kupmax,kupmax,kupmin);
	fprintf(o,"4. noktax:%f y:%f z:%f \n",kupmin,kupmax,kupmin);
	fprintf(o,"5. noktax:%f y:%f z:%f \n",kupmin,kupmin,kupmax);
	fprintf(o,"6. noktax:%f y:%f z:%f \n",kupmax,kupmin,kupmax);
	fprintf(o,"7. noktax:%f y:%f z:%f \n",kupmax,kupmax,kupmax);
	fprintf(o,"8. noktax:%f y:%f z:%f \n",kupmin,kupmax,kupmax);
}
void islem4(int a,int b, int c,int yarc,float noktx[],float nokty[],float noktz[],int sayi){
	FILE *o;
	o=fopen("output.txt","a");
	int i;
	float uz,x,y,z;
	for(i=0;i<sayi;i++){
				
				x=pow((noktx[i]-a),2);
				y=pow((nokty[i]-b),2);
				z=pow((noktz[i]-c),2);
				uz=sqrt((x+y+z));
				if(uz<yarc){
					fprintf(o,"%d. nokta verilen kurenin icindedir.\n",i);
					fprintf(o,"nokta bilgileri: %f  %f  %f\n",noktx[i],nokty[i],noktz[i]);
}
				else if(uz==yarc){
					fprintf(o,"%d. nokta verilen kurenin uzerindedir.",i);
					fprintf(o,"nokta bilgileri: %f  %f  %f\n",noktx[i],nokty[i],noktz[i]);
}
}

}
void islem5(float noktx[],int sayi,float nokty[],float noktz[]){
	FILE *o;
	o=fopen("output.txt","a");
	float x,y,z,uz,top=0,ort;
	int i,j;
	double topus; 
	for(i=0;i<sayi-1;i++){
			for(j=i+1;j<sayi;j++){
				
				x=pow(noktx[i]-noktx[j],2);
				y=pow(nokty[i]-nokty[j],2);
				z=pow(noktz[i]-noktz[j],2);
				uz=sqrt((x+y+z));
				top+=uz;
}
}
	topus=sayi*(sayi-1)/2.0;
	ort=top/topus;
	fprintf(o,"noktalar arasi uzakliklarin ortalama degeri:%f\n",fabs(ort));
}







int main() { 
	//deðiþken tanýmlamalarý
	int isl=0,i=0,i2=0,j=0,sayi1,sayi2,bx,by,bz,yarc,d,r=0,r2=0,t1,t2,q,q2,b1,u=0,u2=0,b2;
	char num1[10],yor1[50],ver1[10],alan1[10],veri1[2][10],al1[40],su1[10],num2[10],yor2[50],ver2[10],alan2[10],veri2[2][10],al2[40],su2[10];
	int a[10000],b[10000],c[10000];
	float noktx1[100000],nokty1[100000],noktz1[100000],noktx2[100000],nokty2[100000],noktz2[100000];
   	FILE *f;
    FILE *f2; 
   	FILE *o;
   	o=fopen("output.txt","a");
	f=fopen("dhga.txt","r");   
	f2=fopen("dhgaa.txt","r");
	while(!feof(f)){
    		fscanf(f,"%c",&yor1[r]);
    		if(yor1[r]=='\n'){
    			break;
}
			r++;
} 
		fscanf(f,"%s %d",&ver1,&t1);
		fscanf(f,"%s",&alan1);
		for(q=0;;q++){
			fscanf(f,"%c",&al1[q]);
			if(!isspace(al1[q])){
			su1[u]=al1[q];
			u++;
}
			if(al1[q]=='\n'){
				break;
} 
			
} 
		fscanf(f,"%s  %d",&num1,&sayi1); 
		fscanf(f,"%s %s",&veri1[0],&veri1[1]);
		b1=strlen(su1);
		fprintf(o,"dosya %s %d olarak tanimlanmistir\n",ver1,t1);
		if(b1==6){
			fprintf(o,"dosya koordinatlara ek renk bilgisi ile verilmistir\n");
}
		else if(b1==3){
			fprintf(o,"dosya koordinat bilgileri ile verilmistir\n");
}
		else{printf("hata");
}
	
   		fprintf(o,"dosyada %d adet nokta vardir\n",sayi1);

		while(!feof(f)){
        	fscanf(f,"%f %f %f",&noktx1[i],&nokty1[i],&noktz1[i]);
        	fscanf(f,"%d %d %d\n",&a[i],&b[i],&c[i]);
       		i++;
}


	
    	
    	
 
		while(!feof(f2)){
    		fscanf(f2,"%c",&yor2[r2]);
    		if(yor2[r2]=='\n'){
    			break;
}
			r2++;
} 
		fscanf(f2,"%s %d",&ver2,&t2);
		fscanf(f2,"%s",&alan2);
		for(q2=0;;q2++){
			fscanf(f2,"%c",&al2[q2]);
			if(!isspace(al2[q2])){
			su2[u2]=al2[q2];
			u2++;
}
			if(al2[q2]=='\n'){
				break;
} 
			
} 
		fscanf(f2,"%s  %d",&num2,&sayi2); 
		fscanf(f2,"%s %s",&veri2[0],&veri2[1]);
		b2=strlen(su2);
		fprintf(o,"dosya %s %d olarak tanimlanmistir\n",ver2,t2);
		if(b2==6){
			fprintf(o,"dosya koordinatlara ek renk bilgisi ile verilmistir\n");
}
		else if(b2==3){
			fprintf(o,"dosya koordinat bilgileri ile verilmistir\n");
}
		else{printf("hata");
}
	
   		fprintf(o,"dosyada %d adet nokta vardir\n",sayi2);

		while(!feof(f2)){
        	fscanf(f2,"%f %f %f",&noktx2[i2],&nokty2[i2],&noktz2[i2]);
        	
       		i2++;
}

	//iþlem menüsü
	printf("en yakin en uzak nokta icin 2\n");
	printf("tum noktalarin oldugu kup icin 3\n");
	printf("kure icinde kalan noktalar icin 4\n");
	printf("noktalar arasindaki uzaklik ortalamasi icin 5\n");
 	for(;;){
		printf("yapilacak islemi secin");
		printf("(islem menusunden cikis icin 9):");
		scanf("%d",&isl);
		if(isl==9){
		fprintf(o,"islem menusunden cikis yapildi.\n");
		break;
}
		fprintf(o,"secim %d\n",isl);
		
		// en yakýn en uzak nokta iþlemi
	if(isl==2){
		islem2(sayi1,noktx1,nokty1,noktz1);
		islem2(sayi2,noktx2,nokty2,noktz2);	
} //küp iþlemi
	else if(isl==3){
		islem3(noktx1,nokty1,noktz1,sayi1);
		islem3(noktx2,nokty2,noktz2,sayi2);
} //kure iþlemi
	else if(isl==4){
		printf("kurenin x y ve z degerini ve yaricapini girin:\n");
		scanf("%d %d %d %d",&bx,&by,&bz,&yarc);
		fprintf(o,"kurenin x degeri %d\n",bx);
		fprintf(o,"kurenin y degeri %d\n",by);
		fprintf(o,"kurenin z degeri %d\n",bz);
		fprintf(o,"kurenin yarýcap degeri %d\n",yarc);
		islem4(bx,by,bz,yarc,noktx1,nokty1,noktz1,sayi1);
		islem4(bx,by,bz,yarc,noktx2,nokty2,noktz2,sayi2);
			
} //uzaklýklarýn ortalamasý iþlemi
	else if(isl==5){
		islem5(noktx1,sayi1,nokty1,noktz1);
		islem5(noktx2,sayi2,nokty2,noktz2);
		
} 
 	else{
 		fprintf(o,"hatali islem sectiniz.\n");
 		printf("hata...\n");
 		break;
} 
}




    
	return 0;

}
*/
