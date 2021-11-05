export class AuthModel {
  token:string;
  expiration:string;

  setAuth(auth: AuthModel) {
    this.token = auth.token;
    this.expiration = auth.expiration;
  }
}
