package pl2pr3;

import java.awt.Color;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JCheckBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.SimpleDateFormat;
import java.util.GregorianCalendar;


public class pl2pr3 extends JFrame implements ActionListener {
	private static JFrame f;
    private static JPanel pkayit,pyonetim,pana,para,pizle,pyan,poneri;
    private static JButton giris,ekle,ara,izle,ara1,vaz;
    public static ImageIcon arplan;
    public static JLabel plan,plan1,kulad,sifre,adi,maili,sifresi,dyili,ad,tur,idsi,veya;
    private static JTextField kuladtxt,sifretxt,adtxt,turtxt,aditxt,mailitxt,sifresitxt,dyilitxt,idtxt;
    static String a,b,kytadi,kytmaili,kytsifresi,kytdyili,kytid;
    private static int i=0,j,say=0,bid,baid,pay=1,fay=0,day=0,grsid,limitid=0,e;
    private static int ptint[][],kpint[][],progint[][],kullint[][],o=0,t=0,k=0,m=0,n=0,turint[],dizin[];
    private static String kullstr[][],progstr[][],turstr[],kpstr[],araad,aratur;
    static String url="jdbc:sqlite:C:\\Users\\izely\\Desktop\\veri.db";
	static Connection conn;
	
	
	public static void yansit(String yans) {
		pyan.setLayout(null);
		
		
		plan1.setSize(1200,650);	
		
		izle=new JButton(yans);
	    izle.setForeground(Color.green);
	    izle.setBounds((day*220),(fay*90), 200,80);
	if(pay%5==0) {
		day=0;
		fay++;
	} else {
		
		day++;
	}
	    pay++;
		f.setContentPane(pyan);
	    f.setResizable(false);
	    f.setVisible(true);
	    plan1.getBaseline(15, 10);
	    
	    
	
	pyan.add(izle);
	pyan.add(plan1);
	
	izle.addActionListener(new ActionListener() 
    {  

		
		public void actionPerformed(ActionEvent e) {
			
			
			
			for(i=0;i<progint.length;i++) {
				if(yans.equals(progstr[i][0])) {
					SimpleDateFormat bicim3=new SimpleDateFormat("dd:MM:yyyy  hh:mm");
					GregorianCalendar gcalender=new GregorianCalendar();
					String zaman=bicim3.format(gcalender.getTime());
					String kayitsql="INSERT INTO kullprog (id, progid, kulid, tarih)"+
					" VALUES ('"+(limitid+400)+"','"+progint[i][0]+"', '"+grsid+"', '"+zaman+"')";
					limitid++;
			datakayit(kayitsql);
				}
			}
		}
    });
	
	}
	
	
	 public static void izle() {
	    	int dizi[]=new int [35];
	    	pizle= new JPanel();
			pizle.setLayout(null);
			
			arplan=new ImageIcon("125.jpg");
			plan1=new JLabel(arplan);
			plan1.setSize(1200,650);	
	    	
			f.setContentPane(pizle);
		    f.setResizable(false);
		    f.setVisible(true);
		    plan1.getBaseline(15, 10);
		    
		    
		pizle.add(plan1);
			    
			for(i=0;i<35;i++) {
				dizi[i]=(int)(Math.random()*70);
				for(j=0;j<i;j++) {
					if(dizi[i]==dizi[j]) {
						i--;
					}
				}
			}
			for(m=0;m<35;m++) {
			
				e=dizi[m];
				yansit(progstr[e][0]);
			}
			    
			    
			    
			    
	    }
	
	
	
	
    public static void ara() {
    	para= new JPanel();
		para.setLayout(null);
		
		arplan=new ImageIcon("125.jpg");
		plan1=new JLabel(arplan);
		plan1.setSize(1200,650);	
		
		ad=new JLabel("ad");
	    ad.setForeground(Color.cyan);
	    ad.setBounds(65, 130, 125, 25);
	    adtxt= new JTextField();
	    adtxt.setBackground(Color.white);
	    adtxt.setBounds(165, 130, 125, 25);
	    
	    veya=new JLabel("veya");
	    veya.setForeground(Color.cyan);
	    veya.setBounds(165, 180, 125, 25);
	    
	    tur=new JLabel("tur");
	    tur.setForeground(Color.cyan);
	    tur.setBounds(65, 230, 125, 25);
	    turtxt= new JTextField();
	    turtxt.setBackground(Color.white);
	    turtxt.setBounds(165, 230, 125, 25);
		
		
		    ara1=new JButton("ARA");
		    ara1.setForeground(Color.green);
		    ara1.setBounds(65,330, 100, 25);
		    
		    
		    
		    
		    
		    f.setContentPane(para);
		    f.setResizable(false);
		    f.setVisible(true);
		    plan1.getBaseline(15, 10);
		    
		    
    	
    	para.add(ad);
    	para.add(tur);
    	para.add(veya);
    	para.add(adtxt);
    	para.add(turtxt);
    	para.add(ara1);
		para.add(plan1);
		
    	
		ara1.addActionListener(new ActionListener() 
	    {  

			
			public void actionPerformed(ActionEvent e) {
			araad=adtxt.getText();
			aratur=turtxt.getText();
			
			for(i=0;i<progstr.length;i++) {
				if(araad.equals(progstr[i][0])) {
					yansit(progstr[i][0]);
				}
			
				if(aratur.equals(turstr[i])) {
					bid=turint[i];
					for(j=0;j<110;j++) {
						
						if(bid==ptint[j][2]) {
							
							baid=ptint[j][1];
							for(m=0;m<progstr.length;m++) {
								if(baid==progint[m][0]) {
									
									yansit(progstr[m][0]);
								}
							}
						}
						
						
					}
				}
				
			}
		
			
			
}

});
    	
    }
   
    public static void datakayit(String kaydedilecek) {
    	Statement srt;
    	try {
    		srt=conn.createStatement();
			srt.executeUpdate(kaydedilecek);
			System.out.println("KAYDEDÝLDÝ");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
    	
    	
    	
    }
    public static void oneri() {
    	poneri= new JPanel();
		poneri.setLayout(null);
		
		arplan=new ImageIcon("125.jpg");
		plan1=new JLabel(arplan);
		plan1.setSize(1200,650);	
    	
		    
		
		    
		    f.setContentPane(poneri);
		    f.setResizable(false);
		    f.setVisible(true);
		    plan1.getBaseline(15, 10);
		    
		    
		poneri.add(plan1);
		
		
		  
				
		 dizin=new int[6];
			for(i=0;i<6;i++) {
				dizin[i]=(int)(Math.random()*70);
				for(j=0;j<i;j++) {
					if(dizin[i]==dizin[j]) {
						i--;
					}
				}
			}
			for(m=0;m<6;m++) {
			
				e=dizin[m];
				yansit(progstr[e][0]);
			}
    }
    	
   public static void kayit() {
	  
	   
	    
		pkayit= new JPanel();
		pkayit.setLayout(null);
		
		arplan=new ImageIcon("125.jpg");
		plan1=new JLabel(arplan);
		plan1.setSize(1200,650);	
		
		idsi=new JLabel("Id:");
	    idsi.setForeground(Color.cyan);
	    idsi.setBounds(65, 30, 125, 25);
	    idtxt= new JTextField();
	    idtxt.setBackground(Color.white);
	    idtxt.setBounds(165, 30, 125, 25);
		
		adi = new JLabel("Ad:");
	    adi.setForeground(Color.cyan);
	    adi.setBounds(65, 80, 125, 25);
	    aditxt= new JTextField();
	    aditxt.setBackground(Color.white);
	    aditxt.setBounds(165, 80, 125, 25);
	    
	    maili=new JLabel("Mail:");
	    maili.setForeground(Color.cyan);
	    maili.setBounds(65, 130, 125, 25);
	    mailitxt = new JTextField();
	    mailitxt.setBackground(Color.white);
	    mailitxt.setBounds(165, 130, 125, 25);
	    
	    sifresi=new JLabel("Sifre:");
	    sifresi.setForeground(Color.cyan);
	    sifresi.setBounds(65, 180, 125, 25);
	    sifresitxt= new JTextField();
	    sifresitxt.setBackground(Color.white);
	    sifresitxt.setBounds(165, 180, 125, 25);
	    
	    dyili=new JLabel("Doðum yýlý:");
	    dyili.setForeground(Color.cyan);
	    dyili.setBounds(65, 230, 125, 25);
	    dyilitxt= new JTextField();
	    dyilitxt.setBackground(Color.white);
	    dyilitxt.setBounds(165, 230, 125, 25);

	    
	    
	    ekle=new JButton("KAYIT");
	    ekle.setForeground(Color.green);
	    ekle.setBounds(65, 300, 125, 25);
	    
	    f.setContentPane(pkayit);
	    f.setResizable(false);
	    f.setVisible(true);
	    plan1.getBaseline(15, 10);
	    pkayit.add(idsi);
	    pkayit.add(adi);
	    pkayit.add(maili);
	    pkayit.add(sifresi);
	    pkayit.add(dyili);
	    pkayit.add(idtxt);
	    pkayit.add(aditxt);
	    pkayit.add(mailitxt);
	    pkayit.add(sifresitxt);
	    pkayit.add(dyilitxt);
	    pkayit.add(ekle);
	    pkayit.add(plan1);
		
		
		 ekle.addActionListener(new ActionListener() 
		    {  
			
				public void actionPerformed(ActionEvent e) {
					kytid=idtxt.getText();
					kytadi=aditxt.getText();
					kytmaili=mailitxt.getText();
					kytsifresi=sifresitxt.getText();
					kytdyili=dyilitxt.getText();
					grsid=Integer.parseInt(kytid);
					String kayitsql="INSERT INTO kullanýcý (kulid, ad, mail, sifre, dyýlý)"+
							" VALUES ('"+kytid+"','"+kytadi+"', '"+kytmaili+"', '"+kytsifresi+"', '"+kytdyili+"')";
					datakayit(kayitsql);
					
					oneri();
					
				}
		    });
				}
    	
    
    public static void yonetim() {
    	
    	pyonetim= new JPanel();
		pyonetim.setLayout(null);
		
		arplan=new ImageIcon("125.jpg");
		plan1=new JLabel(arplan);
		plan1.setSize(1200,650);	
    	
		    ara=new JButton("ARA");
		    ara.setForeground(Color.green);
		    ara.setBounds(10,10, 100, 125);
		    
		    izle=new JButton("ÝZLE");
		    izle.setForeground(Color.green);
		    izle.setBounds(110, 10, 100, 125);
		    
		    
		    
		    f.setContentPane(pyonetim);
		    f.setResizable(false);
		    f.setVisible(true);
		    plan1.getBaseline(15, 10);
		    
		    
    	pyonetim.add(ara);
    	pyonetim.add(izle);
		pyonetim.add(plan1);
		
		
		 ara.addActionListener(new ActionListener() 
		    {  

				
				public void actionPerformed(ActionEvent e) {
					
					ara();
					  
				}
				});
		 izle.addActionListener(new ActionListener() 
		    {  

				
				public void actionPerformed(ActionEvent e) {
					izle();
				}
				
		    }); 


    	
    	
    	
    	
    	
				
    }
    public static void database() {
    	ptint=new int[110][6];
		kpint=new int[110][6];
		progint=new int[110][6];
		kullint=new int[110][6];
		turint=new int[110];
		kullstr=new String[110][6];
		progstr=new String[110][6];
		turstr=new String[110];
		kpstr=new String[110];
		
try {
	conn=DriverManager.getConnection(url);
	System.out.println("BAÐLANTI BAÞARILI");
	String sql="select * from kullanýcý";
	String sql1="select * from program";
	String sql2="select * from tur";
	String sql3="select * from kullprog";
	String sql4="select * from progtur";
	Statement st=conn.createStatement();
	Statement st1=conn.createStatement();
	Statement st2=conn.createStatement();
	Statement st3=conn.createStatement();
	Statement st4=conn.createStatement();
	ResultSet re=st.executeQuery(sql);
	ResultSet re1=st1.executeQuery(sql1);
	ResultSet re2=st2.executeQuery(sql2);
	ResultSet re3=st3.executeQuery(sql3);
	ResultSet re4=st4.executeQuery(sql4);
	while(re.next()) {
		kullint[o][0]=re.getInt("kulid");
		kullstr[o][0]=re.getString("ad");
		kullstr[o][1]=re.getString("mail");
		kullstr[o][2]=re.getString("sifre");
		kullint[o][1]=re.getInt("dyýlý");
		o++;
	}
	while(re1.next()) {
		progint[t][0]=re1.getInt("progid");
		progstr[t][0]=re1.getString("adi");
		progstr[t][1]=re1.getString("tip");
		progint[t][1]=re1.getInt("bölüm");
		progint[t][2]=re1.getInt("süre"); 
		t++;
	}
	while(re2.next()) {
		turint[k]=re2.getInt("turid");
		turstr[k]=re2.getString("adi");
		k++;
	}
	while(re3.next()) {
		kpint[m][0]=re3.getInt("kulid");
		kpint[m][1]=re3.getInt("progid");
		kpint[m][2]=re3.getInt("id");
		kpstr[m]=re3.getString("tarih");
		
		m++;
		
	}
	while(re4.next()) {
		ptint[n][0]=re4.getInt("id");
		ptint[n][1]=re4.getInt("progid");
		ptint[n][2]=re4.getInt("turid");
		n++;
	}	
	
	
} catch (SQLException e) {
	System.out.println("VERÝTABANI OKUNAMADI.");
	e.printStackTrace();
}
	}
    

	public static void main(String[] args) {
		pyan=new JPanel();
	
		database();
	

		for(i=0;i<kpint.length;i++) {
			
			if(kpint[i][2]!=0) {
				limitid++;
			}
		}
		f=new JFrame("NETFLIX");
		f.setSize(1200,650);
		f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	   
	    
		pana= new JPanel();
		pana.setLayout(null);
		
		arplan=new ImageIcon("125.jpg");
		plan=new JLabel(arplan);
		plan.setSize(1200,650);	
		
		
	    
	    kulad=new JLabel("EMAIL");
	    kulad.setForeground(Color.cyan);
	    kulad.setBounds(65, 80, 125, 25);
	    kuladtxt= new JTextField();
	    kuladtxt.setBackground(Color.white);
	    kuladtxt.setBounds(165, 80, 125, 25);
	    
	    sifre=new JLabel("SIFRE");
	    sifre.setForeground(Color.cyan);
	    sifre.setBounds(65, 130, 125, 25);
	    sifretxt= new JTextField();
	    sifretxt.setBackground(Color.white);
	    sifretxt.setBounds(165, 130, 125, 25);
	    
	    giris = new JButton("GIRIS");
	    giris.setBackground(Color.LIGHT_GRAY);
	    giris.setBounds(400, 100, 90, 50);
	    
	    f.setContentPane(pana);
	    f.setResizable(false);
	    f.setVisible(true);
	    plan.getBaseline(15, 10);
	   
	    pana.add(kulad);
	    pana.add(sifre);
	    pana.add(kuladtxt);
	    pana.add(sifretxt);
	    pana.add(giris);
		pana.add(plan);

		 giris.addActionListener(new ActionListener() 
		    {  

				
				public void actionPerformed(ActionEvent e) {
					a=kuladtxt.getText();
			    	b=sifretxt.getText();
			    	for(i=0;i<kullstr.length;i++) {
			    if(a.equals(kullstr[i][1])&&b.equals(kullstr[i][2])) {
			    	grsid=kullint[i][0];
			    	yonetim();
			    	
			    	
					
				}
			   
			    else {
			    	say++;
			    }
				
			}
			    	if(say==kullstr.length) {
			    		
			    		kayit();
			    	}
				}
				
		    }); 


		 
		 
		 
	}


	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		
	}


	 
}

	
    