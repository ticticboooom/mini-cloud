import Axios, {AxiosResponse, AxiosPromise} from 'axios';
import { LoginResponseModel, loginModel } from './types';
export default class ApiService {
    public static postLogin(model: loginModel): AxiosPromise<LoginResponseModel> {
        return Axios.post("/api/aqccount/login", model);
    }
}