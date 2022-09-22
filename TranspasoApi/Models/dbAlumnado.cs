namespace TranspasoApi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbAlumnado : DbContext
    {
        public dbAlumnado()
            : base("name=dbAlumnado")
        {
        }

        public virtual DbSet<al_adhe_carreras> al_adhe_carreras { get; set; }
        public virtual DbSet<al_adhe_materias> al_adhe_materias { get; set; }
        public virtual DbSet<al_adhe_materias_e> al_adhe_materias_e { get; set; }
        public virtual DbSet<al_adhe_requisitos> al_adhe_requisitos { get; set; }
        public virtual DbSet<al_areas> al_areas { get; set; }
        public virtual DbSet<al_carre_comision> al_carre_comision { get; set; }
        public virtual DbSet<al_correlatividad> al_correlatividad { get; set; }
        public virtual DbSet<al_fe_examen> al_fe_examen { get; set; }
        public virtual DbSet<al_fe_parcial> al_fe_parcial { get; set; }
        public virtual DbSet<al_materias> al_materias { get; set; }
        public virtual DbSet<al_nota_examen> al_nota_examen { get; set; }
        public virtual DbSet<al_nota_parcial> al_nota_parcial { get; set; }
        public virtual DbSet<al_notas> al_notas { get; set; }
        public virtual DbSet<al_plan> al_plan { get; set; }
        public virtual DbSet<al_requisitos> al_requisitos { get; set; }
        public virtual DbSet<auditoria> auditoria { get; set; }
        public virtual DbSet<gc_adherentes> gc_adherentes { get; set; }
        public virtual DbSet<gc_niveles> gc_niveles { get; set; }
        public virtual DbSet<gc_titular> gc_titular { get; set; }
        public virtual DbSet<p_alumno> p_alumno { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<t_condicion1> t_condicion1 { get; set; }
        public virtual DbSet<t_llamado> t_llamado { get; set; }
        public virtual DbSet<t_mesa> t_mesa { get; set; }
        public virtual DbSet<userApi> userApi { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<al_adhe_carreras>()
                .Property(e => e.cod_empre)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_carreras>()
                .Property(e => e.cod_alumno)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_carreras>()
                .Property(e => e.cod_carrera)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_carreras>()
                .Property(e => e.cod_comi)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_carreras>()
                .Property(e => e.anio)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_carreras>()
                .Property(e => e.cod_estado)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_carreras>()
                .Property(e => e.cod_plan)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_materias>()
                .Property(e => e.cod_empre)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_materias>()
                .Property(e => e.cod_materia)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_materias>()
                .Property(e => e.cod_alumno)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_materias>()
                .Property(e => e.cod_comi)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_materias>()
                .Property(e => e.t_cursado)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_materias>()
                .Property(e => e.t_cursado2)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_materias>()
                .Property(e => e.t_cursado3)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_materias>()
                .Property(e => e.cod_estado)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_materias_e>()
                .Property(e => e.cod_empre)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_materias_e>()
                .Property(e => e.cod_materia)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_materias_e>()
                .Property(e => e.cod_alumno)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_materias_e>()
                .Property(e => e.cod_comi)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_materias_e>()
                .Property(e => e.nro_estado)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_materias_e>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_materias_e>()
                .Property(e => e.motivo)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_materias_e>()
                .Property(e => e.cod_estado)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_requisitos>()
                .Property(e => e.cod_empre)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_requisitos>()
                .Property(e => e.cod_titu)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_requisitos>()
                .Property(e => e.cod_estado)
                .IsUnicode(false);

            modelBuilder.Entity<al_adhe_requisitos>()
                .Property(e => e.cod_requi)
                .IsUnicode(false);

            modelBuilder.Entity<al_areas>()
                .Property(e => e.cod_empre)
                .IsUnicode(false);

            modelBuilder.Entity<al_areas>()
                .Property(e => e.cod_area)
                .IsUnicode(false);

            modelBuilder.Entity<al_areas>()
                .Property(e => e.nom_area)
                .IsUnicode(false);

            modelBuilder.Entity<al_areas>()
                .Property(e => e.cod_estado)
                .IsUnicode(false);

            modelBuilder.Entity<al_carre_comision>()
                .Property(e => e.cod_empre)
                .IsUnicode(false);

            modelBuilder.Entity<al_carre_comision>()
                .Property(e => e.cod_carrera)
                .IsUnicode(false);

            modelBuilder.Entity<al_carre_comision>()
                .Property(e => e.cod_comi)
                .IsUnicode(false);

            modelBuilder.Entity<al_carre_comision>()
                .Property(e => e.curso)
                .IsUnicode(false);

            modelBuilder.Entity<al_carre_comision>()
                .Property(e => e.division)
                .IsUnicode(false);

            modelBuilder.Entity<al_carre_comision>()
                .Property(e => e.turno)
                .IsUnicode(false);

            modelBuilder.Entity<al_carre_comision>()
                .Property(e => e.cod_estado)
                .IsUnicode(false);

            modelBuilder.Entity<al_carre_comision>()
                .Property(e => e.detalle)
                .IsUnicode(false);

            modelBuilder.Entity<al_carre_comision>()
                .Property(e => e.cod_aula)
                .IsUnicode(false);

            modelBuilder.Entity<al_correlatividad>()
                .Property(e => e.cod_empre)
                .IsUnicode(false);

            modelBuilder.Entity<al_correlatividad>()
                .Property(e => e.codigo)
                .IsUnicode(false);

            modelBuilder.Entity<al_correlatividad>()
                .Property(e => e.cod_materia)
                .IsUnicode(false);

            modelBuilder.Entity<al_correlatividad>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<al_correlatividad>()
                .Property(e => e.cod_mat_co)
                .IsUnicode(false);

            modelBuilder.Entity<al_correlatividad>()
                .Property(e => e.cod_estado)
                .IsUnicode(false);

            modelBuilder.Entity<al_correlatividad>()
                .Property(e => e.cod_plan)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_examen>()
                .Property(e => e.cod_empre)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_examen>()
                .Property(e => e.nro_examen)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_examen>()
                .Property(e => e.cod_materia)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_examen>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_examen>()
                .Property(e => e.cod_profe)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_examen>()
                .Property(e => e.cod_vocal1)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_examen>()
                .Property(e => e.cod_vocal2)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_examen>()
                .Property(e => e.modalidad)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_examen>()
                .Property(e => e.nro_acta)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_examen>()
                .Property(e => e.nro_libro)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_examen>()
                .Property(e => e.nro_folio)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_examen>()
                .Property(e => e.mesa)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_examen>()
                .Property(e => e.cod_estado)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_examen>()
                .Property(e => e.cod_plan)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_parcial>()
                .Property(e => e.cod_empre)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_parcial>()
                .Property(e => e.nro_parcial)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_parcial>()
                .Property(e => e.cod_materia)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_parcial>()
                .Property(e => e.cod_comi)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_parcial>()
                .Property(e => e.hora)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_parcial>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_parcial>()
                .Property(e => e.nro_acta)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_parcial>()
                .Property(e => e.cod_estado)
                .IsUnicode(false);

            modelBuilder.Entity<al_fe_parcial>()
                .Property(e => e.cod_plan)
                .IsUnicode(false);

            modelBuilder.Entity<al_materias>()
                .Property(e => e.cod_empre)
                .IsUnicode(false);

            modelBuilder.Entity<al_materias>()
                .Property(e => e.cod_materia)
                .IsUnicode(false);

            modelBuilder.Entity<al_materias>()
                .Property(e => e.cod_carrera)
                .IsUnicode(false);

            modelBuilder.Entity<al_materias>()
                .Property(e => e.nom_materia)
                .IsUnicode(false);

            modelBuilder.Entity<al_materias>()
                .Property(e => e.cod_area)
                .IsUnicode(false);

            modelBuilder.Entity<al_materias>()
                .Property(e => e.cod_estado)
                .IsUnicode(false);

            modelBuilder.Entity<al_materias>()
                .Property(e => e.rotulo)
                .IsUnicode(false);

            modelBuilder.Entity<al_materias>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<al_materias>()
                .Property(e => e.cod_plan)
                .IsUnicode(false);

            modelBuilder.Entity<al_nota_examen>()
                .Property(e => e.cod_empre)
                .IsUnicode(false);

            modelBuilder.Entity<al_nota_examen>()
                .Property(e => e.cod_alumno)
                .IsUnicode(false);

            modelBuilder.Entity<al_nota_examen>()
                .Property(e => e.nro_mesa)
                .IsUnicode(false);

            modelBuilder.Entity<al_nota_examen>()
                .Property(e => e.nro_folio)
                .IsUnicode(false);

            modelBuilder.Entity<al_nota_examen>()
                .Property(e => e.nro_examen)
                .IsUnicode(false);

            modelBuilder.Entity<al_nota_examen>()
                .Property(e => e.asistencia)
                .IsUnicode(false);

            modelBuilder.Entity<al_nota_examen>()
                .Property(e => e.tipo_nota)
                .IsUnicode(false);

            modelBuilder.Entity<al_nota_examen>()
                .Property(e => e.detalle)
                .IsUnicode(false);

            modelBuilder.Entity<al_nota_examen>()
                .Property(e => e.cod_estado)
                .IsUnicode(false);

            modelBuilder.Entity<al_nota_parcial>()
                .Property(e => e.cod_empre)
                .IsUnicode(false);

            modelBuilder.Entity<al_nota_parcial>()
                .Property(e => e.cod_alumno)
                .IsUnicode(false);

            modelBuilder.Entity<al_nota_parcial>()
                .Property(e => e.nro_parcial)
                .IsUnicode(false);

            modelBuilder.Entity<al_nota_parcial>()
                .Property(e => e.asistencia)
                .IsUnicode(false);

            modelBuilder.Entity<al_nota_parcial>()
                .Property(e => e.tipo_nota)
                .IsUnicode(false);

            modelBuilder.Entity<al_nota_parcial>()
                .Property(e => e.cod_estado)
                .IsUnicode(false);

            modelBuilder.Entity<al_notas>()
                .Property(e => e.cod_empre)
                .IsUnicode(false);

            modelBuilder.Entity<al_notas>()
                .Property(e => e.cod_nota)
                .IsUnicode(false);

            modelBuilder.Entity<al_notas>()
                .Property(e => e.tipo_nota)
                .IsUnicode(false);

            modelBuilder.Entity<al_notas>()
                .Property(e => e.calificacion)
                .IsUnicode(false);

            modelBuilder.Entity<al_notas>()
                .Property(e => e.letras)
                .IsUnicode(false);

            modelBuilder.Entity<al_notas>()
                .Property(e => e.cod_estado)
                .IsUnicode(false);

            modelBuilder.Entity<al_plan>()
                .Property(e => e.cod_empre)
                .IsUnicode(false);

            modelBuilder.Entity<al_plan>()
                .Property(e => e.cod_plan)
                .IsUnicode(false);

            modelBuilder.Entity<al_plan>()
                .Property(e => e.nom_plan)
                .IsUnicode(false);

            modelBuilder.Entity<al_plan>()
                .Property(e => e.cod_estado)
                .IsUnicode(false);

            modelBuilder.Entity<al_plan>()
                .Property(e => e.anio)
                .IsUnicode(false);

            modelBuilder.Entity<al_plan>()
                .Property(e => e.cod_carrera)
                .IsUnicode(false);

            modelBuilder.Entity<al_requisitos>()
                .Property(e => e.cod_empre)
                .IsUnicode(false);

            modelBuilder.Entity<al_requisitos>()
                .Property(e => e.cod_requi)
                .IsUnicode(false);

            modelBuilder.Entity<al_requisitos>()
                .Property(e => e.nom_requi)
                .IsUnicode(false);

            modelBuilder.Entity<al_requisitos>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<al_requisitos>()
                .Property(e => e.cod_estado)
                .IsUnicode(false);

            modelBuilder.Entity<al_requisitos>()
                .Property(e => e.rotulo)
                .IsUnicode(false);

            modelBuilder.Entity<auditoria>()
                .Property(e => e.resultadoDetalle)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.cod_empre)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.cod_titu)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.cod_adhe)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.cod_nivel)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.curso)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.division)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.turno)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.cod_doc)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.nro_doc)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.sexo)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.file_foto)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.tipo_alum)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.est_civil)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.nacionalidad)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.titulo)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.otorgado)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.cod_aula)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.cod_estado)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.estado1)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.cod_aux)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.nro_socio)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.nro_matri)
                .IsUnicode(false);

            modelBuilder.Entity<gc_adherentes>()
                .Property(e => e.clave)
                .IsUnicode(false);

            modelBuilder.Entity<gc_niveles>()
                .Property(e => e.cod_empre)
                .IsUnicode(false);

            modelBuilder.Entity<gc_niveles>()
                .Property(e => e.cod_nivel)
                .IsUnicode(false);

            modelBuilder.Entity<gc_niveles>()
                .Property(e => e.nom_nivel)
                .IsUnicode(false);

            modelBuilder.Entity<gc_niveles>()
                .Property(e => e.cod_escue)
                .IsUnicode(false);

            modelBuilder.Entity<gc_niveles>()
                .Property(e => e.curso)
                .IsUnicode(false);

            modelBuilder.Entity<gc_niveles>()
                .Property(e => e.cod_siguie)
                .IsUnicode(false);

            modelBuilder.Entity<gc_niveles>()
                .Property(e => e.cod_estado)
                .IsUnicode(false);

            modelBuilder.Entity<gc_niveles>()
                .Property(e => e.titulo)
                .IsUnicode(false);

            modelBuilder.Entity<gc_niveles>()
                .Property(e => e.cod_plan)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.cod_empre)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.cod_titu)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.pad_apelli)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.pad_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.mad_apelli)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.mad_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.dom_calle)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.dom_nro)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.dom_piso)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.dom_dpto)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.dom_cp1)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.dom_cp2)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.dom_cp3)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.env_calle)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.env_nro)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.env_piso)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.env_dpto)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.env_cp1)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.env_cp2)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.env_cp3)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.celulares)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.e_mail)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.cod_grupo)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.cod_iva)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.cod_cobra)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.cod_zona)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.doc_cod)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.doc_nro)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.cod_nivel)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.tipo_alum)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.cod_estado)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.pad_email)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.mad_email)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.pad_tipo)
                .IsUnicode(false);

            modelBuilder.Entity<gc_titular>()
                .Property(e => e.mad_tipo)
                .IsUnicode(false);

            modelBuilder.Entity<p_alumno>()
                .Property(e => e.cod_empre)
                .IsUnicode(false);

            modelBuilder.Entity<p_alumno>()
                .Property(e => e.cp_codigo)
                .IsUnicode(false);

            modelBuilder.Entity<p_alumno>()
                .Property(e => e.cod_doc)
                .IsUnicode(false);

            modelBuilder.Entity<p_alumno>()
                .Property(e => e.sexo)
                .IsUnicode(false);

            modelBuilder.Entity<p_alumno>()
                .Property(e => e.cod_zona)
                .IsUnicode(false);

            modelBuilder.Entity<p_alumno>()
                .Property(e => e.cod_grupo)
                .IsUnicode(false);

            modelBuilder.Entity<p_alumno>()
                .Property(e => e.cod_iva)
                .IsUnicode(false);

            modelBuilder.Entity<p_alumno>()
                .Property(e => e.cod_perso)
                .IsUnicode(false);

            modelBuilder.Entity<p_alumno>()
                .Property(e => e.nro_actap)
                .IsUnicode(false);

            modelBuilder.Entity<p_alumno>()
                .Property(e => e.nro_actaf)
                .IsUnicode(false);

            modelBuilder.Entity<p_alumno>()
                .Property(e => e.pa_mes)
                .IsUnicode(false);

            modelBuilder.Entity<p_alumno>()
                .Property(e => e.pa_anio)
                .IsUnicode(false);

            modelBuilder.Entity<p_alumno>()
                .Property(e => e.fi_mes)
                .IsUnicode(false);

            modelBuilder.Entity<p_alumno>()
                .Property(e => e.fi_anio)
                .IsUnicode(false);

            modelBuilder.Entity<t_condicion1>()
                .Property(e => e.cod_tipo)
                .IsUnicode(false);

            modelBuilder.Entity<t_condicion1>()
                .Property(e => e.nom_tipo)
                .IsUnicode(false);

            modelBuilder.Entity<t_llamado>()
                .Property(e => e.cod_tipo)
                .IsUnicode(false);

            modelBuilder.Entity<t_llamado>()
                .Property(e => e.nom_tipo)
                .IsUnicode(false);

            modelBuilder.Entity<t_mesa>()
                .Property(e => e.cod_tipo)
                .IsUnicode(false);

            modelBuilder.Entity<t_mesa>()
                .Property(e => e.nom_tipo)
                .IsUnicode(false);

            modelBuilder.Entity<t_mesa>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<userApi>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<userApi>()
                .Property(e => e.clave)
                .IsUnicode(false);

            modelBuilder.Entity<userApi>()
                .Property(e => e.token)
                .IsUnicode(false);
        }
    }
}
