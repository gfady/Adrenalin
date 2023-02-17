import React, { useEffect, useState } from 'react';
import {
  YMaps,
  Map,
  Placemark,
  FullscreenControl,
  ZoomControl,
} from '@pbe/react-yandex-maps';
import styles from './contact.module.css';
import axios from 'axios';
import { ENDPOINTS, createAPIEndpoint } from '../../api';
import Modal from '../Modal/Modal';
// import { clubs } from '../../data/consts';

export default function ContactUs() {
  const [clubs, setClubs] = useState([]);

  useEffect(() => {
    const path = createAPIEndpoint(ENDPOINTS.club, 'getallclubs');

    axios.get(path).then((response) => {
      setClubs(response.data);
    });
  }, []);

  const defaultState = {
    center: [53.904109, 27.552777],
    zoom: 10.5,
  };
  let cords = [
    [53.924071, 27.428818],
    [53.941057, 27.466624],
    [53.931619, 27.695404],
    [53.926897, 27.613865],
    [53.922792, 27.5695],
    [53.906872, 27.515694],
    [53.904109, 27.552777],
    [53.885024, 27.504671],
    [53.873459, 27.498718],
    [53.86336, 27.571816],
    [53.840582, 27.568528],
  ];

  const [modalVisible, setModalVisible] = useState(false);

  const [formValues, setFormValues] = useState({
    name: '',
    number: '',
    select: '',
  });

  const [errors, setErrors] = useState({
    name: '',
    number: '',
  });

  const [isSubmit, setIsSubmit] = useState(false);

  function validate(values) {
    let phoneNumberReg = /^\+375 ((17|29|33|44))-[0-9]{3}-[0-9]{2}-[0-9]{2}$/;
    let errors = {};

    if (!values.name) {
      errors.name = 'Поле имени обязательно для заполнения';
    }
    if (values.select == 'Выберите клуб' || !values.select) {
      errors.select = 'Необходимо выбрать клуб';
    }

    if (!values.number) {
      errors.number = 'Поле номера обязательно для заполнения';
    } else if (phoneNumberReg.test(values.number)) {
      errors.number = 'Введен некорректный номер телефона';
    }

    return errors;
  }

  function handleChange(e) {
    setFormValues({ ...formValues, [e.target.name]: e.target.value });
  }

  async function sendRequest(formValues) {
    const path = createAPIEndpoint(ENDPOINTS.visit, 'createnewvisit');

    const data = {
      visitorName: formValues.name,
      phoneNumber: formValues.number,
      clubId: formValues.select,
    };

    let response = await axios.post(path, JSON.stringify(data), {
      headers: { 'Content-Type': 'application/json' },
    });
    return response;
  }

  async function formSubmit(e) {
    e.preventDefault();
    setErrors(validate(formValues));
    let response = await sendRequest(formValues);
    setIsSubmit(true);
    console.log(response);
  }

  useEffect(() => {
    if (Object.keys(errors).length === 0 && isSubmit) {
      // запрос на сервер с данными
      setModalVisible(true);
      console.log(1);
      setFormValues({ name: '', number: '', select: '' });
    }
  }, [errors]);

  return (
    <div className={styles.cotactUsWrapper}>
      <div className={styles.map}>
        <YMaps>
          <Map width="100%" height="550px" defaultState={defaultState}>
            {cords.map((cord, i) => (
              <Placemark key={i + Date.now()} geometry={cord}></Placemark>
            ))}
            <FullscreenControl options={{ float: 'left' }}></FullscreenControl>
            <ZoomControl />
          </Map>
        </YMaps>
      </div>
      <div id="contactForm" className={styles.formWrapper}>
        <h2>Запишись на гостевой визит</h2>
        <form id={styles.cotactForm} onSubmit={(e) => formSubmit(e)}>
          <select
            name="select"
            onChange={handleChange}
            value={formValues.select}
          >
            <option>Выберите клуб</option>
            {Array.isArray(clubs)
              ? clubs.map((club) => {
                  return (
                    <option value={club.id} key={club.id}>
                      {club.city + ', ' + club.adress}
                    </option>
                  );
                })
              : null}
          </select>
          {errors.select && <p className={styles.error}>{errors.select}</p>}
          <input
            type="text"
            name="name"
            placeholder="Введите ваше имя"
            value={formValues.name}
            onChange={handleChange}
          ></input>
          {errors.name && <p className={styles.error}>{errors.name}</p>}
          <input
            type="text"
            name="number"
            placeholder="Введите ваш номер телефона"
            value={formValues.number}
            onChange={handleChange}
          ></input>
          {errors.number && <p className={styles.error}>{errors.number}</p>}
          <button id={styles.submit} type="submit">
            Хочу в гости!
          </button>
        </form>
        {modalVisible && (
          <Modal visible={modalVisible} setVisible={setModalVisible}>
            <h3>Ваша заявка успешно отправлена!</h3>
            <br></br>
            <h3>
              В течение ближайшего времени, по указанному номеру с Вами свяжется
              администратор выбранного вами клуба "Адреналин" для дальнейшей
              консультации.
            </h3>
          </Modal>
        )}
      </div>
    </div>
  );
}
