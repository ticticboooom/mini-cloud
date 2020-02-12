export interface loginModel{ 
    email: string;
    password: string;
}

export interface LoginResponseModel {
    accessToken: string;
}


export interface RegisterModel {
    firstName: string;
    lastName: string;
    email: string;
    password: string;

}