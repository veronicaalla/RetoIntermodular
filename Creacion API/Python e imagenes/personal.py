class Personal:
    def __init__(self, id, dni, nombre, apellido1, apellido2, direccion, localidad, cp, tlf, activo, departamento_id):
        self.id = id
        self.dni = dni
        self.nombre = nombre
        self.apellido1 = apellido1
        self.apellido2 = apellido2
        self.direccion = direccion
        self.localidad = localidad
        self.cp = cp
        self.tlf = tlf
        self.activo = activo
        self.departamento_id = departamento_id

    def get_id(self):
        return self.id

    def set_id(self, value):
        self.id = value
        
    def get_dni(self):
        return self.dni

    def set_dni(self, value):
        self.dni = value
    
    def get_nombre(self):
        return self.nombre

    def set_nombre(self, value):
        self.nombre = value
    
    def get_apellido1(self):
        return self.apellido1

    def set_apellido1(self, value):
        self.apellido1 = value
        
    def get_apellido2(self):
        return self.apellido2

    def set_apellido2(self, value):
        self.apellido2 = value    
        
    def get_direccion(self):
        return self.direccion

    def set_direccion(self, value):
        self.direccion = value
         
    def get_localidad(self):
        return self.localidad

    def set_localidad(self, value):
        self.localidad = value
        
    def get_cp(self):
        return self.cp

    def set_cp(self, value):
        self.cp = value
        
    def get_tlf(self):
        return self.tlf

    def set_tlf(self, value):
        self.tlf = value
        
    def get_activo(self):
        return self.activo

    def set_activo(self, value):
        self.activo = value
        
    def get_departamento_id(self):
        return self.departamento_id

    def set_departamento_id(self, value):
        self.departamento_id = value