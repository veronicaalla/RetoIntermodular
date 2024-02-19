class Incidencia:
    def __init__(self, num, tipo, subtipo_id, fecha_creacion, fecha_cierre, descripcion, estado, adjunto_url, creador_id, responsable_id, equipo_id):
        self.num = num
        self.tipo = tipo
        self.subtipo_id = subtipo_id
        self.fecha_creacion = fecha_creacion
        self.fecha_cierre = fecha_cierre
        self.descripcion = descripcion
        self.estado = estado
        self.adjunto_url = adjunto_url
        self.creador_id = creador_id
        self.responsable_id = responsable_id
        self.equipo_id = equipo_id

    def get_num(self):
        return self.num

    def set_num(self, value):
        self.num = value
        
    def get_tipo(self):
        return self.tipo

    def set_tipo(self, value):
        self.tipo = value
    
    def get_subtipo_id(self):
        return self.subtipo_id

    def set_subtipo_id(self, value):
        self.subtipo_id = value
    
    def get_fecha_creacion(self):
        return self.fecha_creacion

    def set_fecha_creacion(self, value):
        self.fecha_creacion = value
    
    def get_fecha_cierre(self):
        return self.fecha_cierre

    def set_fecha_cierre(self, value):
        self.fecha_cierre = value
        
    def get_descripcion(self):
        return self.descripcion

    def set_descripcion(self, value):
        self.descripcion = value
        
    def get_estado(self):
        return self.estado

    def set_estado(self, value):
        self.estado = value
        
    def get_adjunto_url(self):
        return self.adjunto_url

    def set_adjunto_url(self, value):
        self.adjunto_url = value
        
    def get_creador_id(self):
        return self.creador_id

    def set_creador_id(self, value):
        self.creador_id = value
        
    def get_responsable_id(self):
        return self.responsable_id

    def set_responsable_id(self, value):
        self.responsable_id = value
        
    def get_equipo_id(self):
        return self.equipo_id

    def set_equipo_id(self, value):
        self.equipo_id = value