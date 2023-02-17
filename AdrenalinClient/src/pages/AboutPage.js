import React, { useState } from 'react';
import ContactUs from '../components/ContactUs/ContactUs';
import InfoCardsList from '../components/InfoCard/InfoCardsList';
import InfoBlock from '../components/InfoBlock/InfoBlock';
import ClubList from '../components/Clubs/ClubList';
import Modal from '../components/Modal/Modal';

export default function AboutPage() {
  const [modalVisible, setModalVisible] = useState(true);
  return (
    <>
      <InfoCardsList></InfoCardsList>
      <ClubList></ClubList>
      <InfoBlock></InfoBlock>
      <ContactUs></ContactUs>
    </>
  );
}
