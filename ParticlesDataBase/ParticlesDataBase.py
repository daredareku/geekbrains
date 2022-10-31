#//
#//
#//
#//
#//
import sqlite3

#self= new (ParticlesDataBase.__init__(None) )

class ParticlesDataBase():
    def __init__(self):
        self.conn = None
        self.cursor = None

    #self.name('electron')
    el=('electron')
    mm10 = 10 #self.size_mm(10)
    sm8 = 8 #self.size_sm(8)

    def __init__(self):
        self.db = None
        self.el=self.name('electron')
        mm10 = self.size_mm(10)
        sm8 = self.size_sm(8)
        #def __init__(self):
        conn=sqlite3.connect(ordering.db)
        cur = conn.cursor()
        pass

    def createParticles(self,particles_data=el):
        cur.execute("""CREATE TABLE IF NOT EXISTS particles(
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            name TEXT,
            iEROLEPTON REAL,
            R REAL, # sm, SGS
            m REAL, # gramm
            vg REAL,# Hz
            vy REAL);# Reserved
            """)
        conn.commit()

    def insertParticles(self,particles_data=el):
        cur.execute("""INSERT INTO particles(name,iEROLEPTON,R,m,vg,vy)""")
        
    def createRoliks(self,roliks_data=mm10):
        cur.execute("""CREATE TABLE IF NOT EXISTS roliks(
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            name TEXT,
            iEROLEPTON REAL,
            R REAL, # sm, SGS
            rr REAL,
            m REAL, # gramm
            vg REAL,# Hz
            vy REAL);# Reserved
            """)
        conn.commit()        

    def createDisks(self,disks_data=sm8):
        cur.execute("""CREATE TABLE IF NOT EXISTS disks(
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            name TEXT,
            iEROLEPTON REAL,
            R REAL, # sm, SGS
            m REAL, # gramm
            vg REAL,# Hz
            vy REAL);# Reserved
            """)
        conn.commit()

    def createBuses(self, buses_data=sm8):
        cur.execute("""CREATE TABLE IF NOT EXISTS particles(
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            name TEXT,
            driver TEXT,
            R REAL, # sm, SGS
            m REAL, # KILOgramms
            vg REAL,# speed
            vy REAL);# Reserved
            """)
        conn.commit()

    def get_particles_data(self):

        return self._particles_data

    def set_particles_data(self, particles_data):
        self._particles_data = particles_data

    def get_particles_fermions(self):
        return self._particles_fermions

    def set_particles_fermions(self, particles_fermions):
        self._particles_fermions = particles_fermions

