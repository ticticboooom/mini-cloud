import Axios, {AxiosResponse, AxiosPromise} from 'axios';
import { LoginResponseModel, loginModel, RegisterModel } from './types';
export default class ApiService {
    public static postLogin(model: loginModel): AxiosPromise<LoginResponseModel> {
        return Axios.post("/api/account/login", model);
    }
    public static postRegister(model: RegisterModel): AxiosPromise {
        return Axios.post("/api/account/register", model);
    }
}