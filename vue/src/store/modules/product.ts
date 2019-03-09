import {Store,Module,ActionContext} from 'vuex'
import ListModule from './list-module'
import ListState from './list-state'
import Product from '../entities/product'
import Ajax from '../../lib/ajax'
import PageResult from '@/store/entities/page-result';

interface ProductState extends ListState<Product>{
    editProduct:Product;
    permissions:Array<string>
}
class ProductModule extends ListModule<ProductState,any,Product>{
    state={
        totalCount:0,
        currentPage:1,
        pageSize:10,
        list: new Array<Product>(),
        loading:false,
        editProduct:new Product(),
        permissions:new Array<string>()
    }
    actions={
        async getAll(context:ActionContext<ProductState,any>,payload:any){
            context.state.loading=true;
            let reponse=await Ajax.get('/api/services/app/Product/GetAll',{params:payload.data});
            context.state.loading=false;
            let page=reponse.data.result as PageResult<Product>;
            context.state.totalCount=page.totalCount;
            context.state.list=page.items;
        },
        async create(context:ActionContext<ProductState,any>,payload:any){
            await Ajax.post('/api/services/app/Product/Create',payload.data);
        },
        async update(context:ActionContext<ProductState,any>,payload:any){
            await Ajax.put('/api/services/app/Product/Update',payload.data);
        },
        async delete(context:ActionContext<ProductState,any>,payload:any){
            await Ajax.delete('/api/services/app/Product/Delete?Id='+payload.data.id);
        },
        async get(context:ActionContext<ProductState,any>,payload:any){
            let reponse=await Ajax.get('/api/services/app/Product/Get?Id='+payload.id);
            return reponse.data.result as Product;
        },
        async getAllPermissions(context:ActionContext<ProductState,any>){
            let reponse=await Ajax.get('/api/services/app/Product/getAllPermissions');
            context.state.permissions=reponse.data.result.items;
        }
    };
    mutations={
        setCurrentPage(state:ProductState,page:number){
            state.currentPage=page;
        },
        setPageSize(state:ProductState,pagesize:number){
            state.pageSize=pagesize;
        },
        edit(state:ProductState,product:Product){
            state.editProduct=product;
        }
    }
}
const productModule=new ProductModule();
export default productModule;