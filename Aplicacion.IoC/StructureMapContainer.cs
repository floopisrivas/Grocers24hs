﻿using System.Data.Entity;
using Dominio.Entidades;
using Dominio.MetaData;
using Dominio.Repositorio;
using Dominio.UnidadDeTrabajo;
using Infraestructura.Repositorio;
using Infraestructura.UnidadDeTrabajo;
using IServicio.Articulo;
using IServicio.Configuracion;
using IServicio.Departamento;
using IServicio.Deposito;
using IServicio.Iva;
using IServicio.ListaPrecio;
using IServicio.Localidad;
using IServicio.Marca;
using IServicio.Persona;
using IServicio.Provincia;
using IServicio.Rubro;
using IServicio.Seguridad;
using IServicio.UnidadMedida;
using IServicio.Usuario;
using IServicios.BajaArticulo;
using IServicios.Caja;
using IServicios.Contador;
using IServicios.MotivoBaja;
using IServicios.Precio;
using IServicios.PuestoTrabajo;
using IServicios.Comprobantes;
using Presentacion.Core.Articulo;
using Servicios.Articulo;
using Servicios.BajaArticulo;
using Servicios.Caja;
using Servicios.CondicionIva;
using Servicios.Configuracion;
using Servicios.Contador;
using Servicios.Departamento;
using Servicios.Deposito;
using Servicios.Iva;
using Servicios.ListaPrecio;
using Servicios.Localidad;
using Servicios.Marca;
using Servicios.MotivoBaja;
using Servicios.Persona;
using Servicios.Precio;
using Servicios.Provincia;
using Servicios.PuestoTrabajo;
using Servicios.Rubro;
using Servicios.Seguridad;
using Servicios.UnidadMedida;
using Servicios.Usuario;
using Servicios.Comprobantes;
using Servicios.CuentaCorriente;

using StructureMap;
using IServicios.CuentaCorriente;

namespace Aplicacion.IoC
{
    public class StructureMapContainer
    {
        public void Configure()
        {
            ObjectFactory.Configure(x =>
            {
                x.For(typeof(IRepositorio<>)).Use(typeof(Repositorio<>));

                x.ForSingletonOf<DbContext>();

                x.For<IUnidadDeTrabajo>().Use<UnidadDeTrabajo>();

                // =================================================================== //

                x.For<IProvinciaServicio>().Use<ProvinciaServicio>();

                x.For<IDepartamentoServicio>().Use<DepartamentoServicio>();

                x.For<ILocalidadServicio>().Use<LocalidadServicio>();

                x.For<ICondicionIvaServicio>().Use<CondicionIvaServicio>();

                x.For<IPersonaServicio>().Use<PersonaServicio>();

                x.For<IClienteServicio>().Use<ClienteServicio>();

                x.For<IEmpleadoServicio>().Use<EmpleadoServicio>();

                //*********************************************//
                x.For<IUsuarioServicio>().Use<UsuarioServicio>();

                x.For<ISeguridadServicio>().Use<SeguridadServicio>();

                x.For<IConfiguracionServicio>().Use<ConfiguracionServicio>();

                x.For<IListaPrecioServicio>().Use<ListaPrecioServicio>();

                x.For<IArticuloServicio>().Use<ArticuloServicio>();

                x.For<IIvaServicio>().Use<IvaServicio>();

                x.For<IMarcaServicio>().Use<MarcaServicio>();

                x.For<IRubroServicio>().Use<RubroServicio>();

                x.For<IUnidadMedidaServicio>().Use<UnidadMedidaServicio>();

                x.For<IMotivoBajaServicio>().Use<MotivoBajaServicio>();

                x.For<IBajaArticuloServicio>().Use<BajaArticuloServicio>();

                x.For<IPuestoTrabajoServicio>().Use<PuestoTrabajoServicio>();

                x.For<IDepositoSevicio>().Use<DepositoServicio>();

                x.For<IPrecioServicio>().Use<PrecioServicio>();

                x.For<IContadorServicio>().Use<ContadorServicio>();

                x.For<ICajaServicio>().Use<CajaServicio>();

                x.For<IComprobanteServicio>().Use<ComprobanteServicio>();

                x.For<IFacturaServicio>().Use<FacturaServicio>();

                x.For<ICuentaCorrienteServicio>().Use<CuentaCorrienteServicio>();

                

            });
        }
    }
}
